using Autodesk.Revit.DB;
using Autodesk.Revit.UI;


namespace B_HelloWorld_RibbonPanel
{
    public class NewSheet_Cmd : IExternalCommand
    {
        // The main Execute method (inherited from IExternalCommand) must be public
        public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,
            ref string message, ElementSet elements)
        {
            TaskDialog.Show("Hazen", "Here goes my SECOND Hazen Form");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
