using System;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

namespace Walkthrough
{
    /// <remarks>
    /// This application's main class. The class must be Public.
    /// </remarks>
    public class CsAddPanel : IExternalApplication
    {
        // Both OnStartup and OnShutdown must be implemented as public method
        public Result OnStartup(UIControlledApplication application)
        {
            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Hazen Tools");

            // Create a push button to trigger a command add it to the ribbon panel.
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("cmdHazenStart",
               "Start New Project", thisAssemblyPath, "Walkthrough.HelloWorld");

            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            // Optionally, other properties may be assigned to the button
            // a) tool-tip
            pushButton.ToolTip = "Start a new project by collecting data from the user. Once you have filled out the form, a new 3D model will automatically be created";

            // b) large bitmap
            Uri uriImage = new Uri(@"C:\00_Lester's Stuff\Revit Docs\API\RevitAPI_Learning\B_HelloWorldRibbon\img\HazenIcon96x96.png");
         BitmapImage largeImage = new BitmapImage(uriImage);
         pushButton.LargeImage = largeImage;

            // OPTION 2 - CREATE BUTTON DIRECTLY ON REVIT RIBBON TAB

            // Create a custom ribbon tab
            String tabName = "This Tab Name";
            application.CreateRibbonTab(tabName);

            // Create two push buttons
            PushButtonData button1 = new PushButtonData("Button1", "My Button #1", thisAssemblyPath, "Walkthrough.HelloWorld");
            PushButtonData button2 = new PushButtonData("Button2", "My Button #2", thisAssemblyPath, "Walkthrough.HelloWorld");

            // Create a ribbon panel
            RibbonPanel m_projectPanel = application.CreateRibbonPanel(tabName, "This Panel Name");

            // Add the buttons to the panel
            List<RibbonItem> projectButtons = new List<RibbonItem>();
            projectButtons.AddRange(m_projectPanel.AddStackedItems(button1, button2));

            return Result.Succeeded;
      }

      public Result OnShutdown(UIControlledApplication application)
      {
         // nothing to clean up in this simple case
         return Result.Succeeded;
      }
   }
   /// <remarks>
   /// The "HelloWorld" external command. The class must be Public.
   /// </remarks>
   [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class HelloWorld : IExternalCommand
        {
            // The main Execute method (inherited from IExternalCommand) must be public
            public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,
                ref string message, ElementSet elements)
            {
                TaskDialog.Show("Hazen", "Here goes my first Hazen Form");
                return Autodesk.Revit.UI.Result.Succeeded;
            }
        }
    }