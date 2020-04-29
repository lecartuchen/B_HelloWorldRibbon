using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using B_HelloWorld_RibbonPanel.Forms;


namespace NEWPROJ_CMD
{
    /// <remarks>
    /// The "NewProj_Cmd" external command. The class must be Public.
    /// </remarks>

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class NewProj_Cmd : IExternalCommand
    {
        public UIDocument uidoc = null;
        public UIDocument uIDocument;

        // private readonly object uidoc;

        // The main Execute method (inherited from IExternalCommand) must be public
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,
            ref string message, ElementSet elements)
        {
            // TaskDialog.Show("Hazen", "Here goes my FIRST Hazen Form");
            NewProjForm.Doc = uidoc;
            NewProjForm FirstForm = new NewProjForm(uIDocument);
            
            FirstForm.Show();
             return Autodesk.Revit.UI.Result.Succeeded;  
        }
    }
}
