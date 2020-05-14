#region Header
//
// CreateNewWall.cs - Creates a wall
//
// May 2020 by Lester Molina
//
#endregion // Header

#region Namespaces
using System;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
#endregion // Namespaces

namespace CommandsCreate
{
    /// <summary>
    /// Creates a wall
    /// </summary>
    [Transaction(TransactionMode.Manual)]
    class CmdCreateNewWall : IExternalCommand
    {
        const double MeterToFeet = 3.2808399;

        /// <summary>
        /// Returns all elements of the requested class,
        /// i.e. System.Type, matching the given built-in
        /// category in the given document.
        /// </summary>
        static FilteredElementCollector
          GetElementsOfType(Document doc, Type type, BuiltInCategory bic)
        {
            FilteredElementCollector collector
              = new FilteredElementCollector(doc);

            collector.OfCategory(bic);
            collector.OfClass(type);

            return collector;
        }

        /// <summary>
        /// Returns all family symbols in the given document
        /// matching the given built-in category.
        /// Todo: Compare this with the FamilySymbolFilter class.
        /// </summary>
        static FilteredElementCollector
          GetFamilySymbols(Document doc, BuiltInCategory bic)
        {
            return GetElementsOfType(doc, typeof(FamilySymbol), bic);
        }

        /// <summary>
        /// Returns the first family symbol found in the given document
        /// matching the given built-in category, or null if none is found.
        /// </summary>
        static FamilySymbol GetFirstFamilySymbol(Document doc, BuiltInCategory bic)
        {
            FamilySymbol s = GetFamilySymbols(doc, bic).FirstElement() as FamilySymbol;

            Debug.Assert(null != s, string.Format("expected at least one {0} symbol in project", bic.ToString()));

            return s;
        }

        /// <summary>
        /// Determines bottom and top levels for creating walls.
        /// In a default empty Revit Architecture project,
        /// 'Level 1' and 'Level 2' will be returned.
        /// </summary>
        /// <returns>True if the two levels are successfully determined.</returns>
        static bool GetBottomAndTopLevels(Document doc, ref Level levelBottom, ref Level levelTop)
        {
            FilteredElementCollector levels = GetElementsOfType(doc, typeof(Level), BuiltInCategory.OST_Levels);

            foreach (Element e in levels)
            {
                if (null == levelBottom)
                {
                    levelBottom = e as Level;
                }
                else if (null == levelTop)
                {
                    levelTop = e as Level;
                }
                else
                {
                    break;
                }
            }

            if (levelTop.Elevation < levelBottom.Elevation)
            {
                Level tmp = levelTop;
                levelTop = levelBottom;
                levelBottom = tmp;
            }
            return null != levelBottom && null != levelTop;
        }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication app = commandData.Application;
            Document doc = app.ActiveUIDocument.Document;

            Autodesk.Revit.Creation.Application createApp = app.Application.Create;

            Autodesk.Revit.Creation.Document createDoc = doc.Create;

            // determines the wall endpoints:

            double length = 5 * MeterToFeet;

            XYZ[] pts = new XYZ[2];

            pts[0] = XYZ.Zero;
            pts[1] = new XYZ(length, 0, 0);

            // determines the levels where 
            // the wall will be located:

            Level levelBottom = null;
            Level levelTop = null;

            if (!GetBottomAndTopLevels(doc, ref levelBottom, ref levelTop))
            {
                message = "Unable to determine " + "wall bottom and top levels";

                return Result.Failed;
            }

            // creates a wall:

            BuiltInParameter topLevelParam = BuiltInParameter.WALL_HEIGHT_TYPE;

            ElementId topLevelId = levelTop.Id;

            Line line = Line.CreateBound(pts[0], pts[1]);

            Wall wall = Wall.Create(doc, line, topLevelId, false);

            Parameter param = wall.get_Parameter(topLevelParam);

            param.Set(topLevelId);

            /*

            // determines wall thickness for tag 
            // offset and profile growth:

            //double wallThickness = wall.WallType.CompoundStructure.Layers.get_Item( 0 ).Thickness; // 2011

            double wallThickness = wall.WallType.GetCompoundStructure().GetLayers()[0].Width; // 2012

            // add door to wall;
            // note that the NewFamilyInstance method 
            // does not automatically add a door tag, 
            // like the ui command does:

            FamilySymbol doorSymbol = GetFirstFamilySymbol(
              doc, BuiltInCategory.OST_Doors);

            if (null == doorSymbol)
            {
                message = "No door symbol found.";
                return Result.Failed;
            }

            XYZ midpoint = Util.Midpoint(pts[0], pts[1]);

            FamilyInstance door = createDoc
              .NewFamilyInstance(
                midpoint, doorSymbol, wall, levelBottom,
                StructuralType.NonStructural);

            // create door tag:

            View view = doc.ActiveView;

            double tagOffset = 3 * wallThickness;

            midpoint += tagOffset * XYZ.BasisY;

            // 2011: TagOrientation.TAG_HORIZONTAL

            IndependentTag tag = createDoc.NewTag(
              view, door, false, TagMode.TM_ADDBY_CATEGORY,
              TagOrientation.Horizontal, midpoint); // 2012

            // create and assign new door tag type:

            FamilySymbol doorTagType
              = GetFirstFamilySymbol(
                doc, BuiltInCategory.OST_DoorTags);

            doorTagType = doorTagType.Duplicate(
              "New door tag type") as FamilySymbol;

            tag.ChangeTypeId(doorTagType.Id);

            // demonstrate changing name of 
            // family instance and family symbol:

            door.Name = door.Name + " modified";
            door.Symbol.Name = door.Symbol.Name + " modified";
            */

            return Result.Succeeded;
        }
    }
}
