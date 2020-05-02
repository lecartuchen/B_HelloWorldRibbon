namespace B_HelloWorld_RibbonPanel
{
    using System.Text;
    using Autodesk.Revit.DB;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.UI.Selection;

    /// <summary>
    /// New Sheet command code to be executed when button is clicked.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
 
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class NewSheet_Cmd : IExternalCommand
    {
        #region Public Methods

        // The main Execute method (inherited from IExternalCommand) must be public
        public Result Execute (ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Application context.
            var uidoc = commandData.Application.ActiveUIDocument;
            var doc = uidoc.Document;

            TaskDialog.Show("Hazen", "Here goes my SECOND Hazen Form");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
        #endregion
    }
}
