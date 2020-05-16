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
    // [Regeneration(RegenerationOption.Manual)]

    public class CmdCreateNewWall : IExternalCommand
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

            Transaction trans = new Transaction(doc);

            trans.Start("Create new Wall");

            BuiltInParameter topLevelParam = BuiltInParameter.WALL_HEIGHT_TYPE;

            ElementId topLevelId = levelTop.Id;

            Line line = Line.CreateBound(pts[0], pts[1]);

            Wall wall = Wall.Create(doc, line, topLevelId, false);

            Parameter param = wall.get_Parameter(topLevelParam);

            param.Set(topLevelId);

            trans.Commit();

            return Result.Succeeded;
        }
    }
}
