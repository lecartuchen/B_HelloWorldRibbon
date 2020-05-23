namespace Hazen_RibbonPanel
{
    using Autodesk.Revit.DB;
    using Autodesk.Revit.UI;

    /// <summary>
    /// New Project external command code to be executed when button is clicked.
    /// The class must be Public.
    /// </summary>
    /// <seealso cref="IExternalCommand"/>

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class NewProj_Cmd : IExternalCommand
    {
        #region Public Methods

        // The main Execute method (inherited from IExternalCommand) must be public
        public Result Execute (ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Application context.
            var uidoc = commandData.Application.ActiveUIDocument;
            // var doc = uidoc.Document;

            // var userInfo = new NewSheet_CmdData();

            using (var windowProj = new NewProjForm(uidoc))
            {
                windowProj.ShowDialog();
                // userInfo = window.GetInformation();
            }

            return Autodesk.Revit.UI.Result.Succeeded;
        }
        #endregion
    }
}
