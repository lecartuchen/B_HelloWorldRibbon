namespace Hazen_RibbonPanel
{
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;
    using CommandsCreate;


    /// <summary>
    /// New Project Data acquisition form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>

    public partial class NewProjForm : System.Windows.Forms.Form
    {
        #region Private Members

        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>
        /// </summary>

        private UIDocument uidoc = null;

        private double length = 5.00;
        private double depth = 5.00;
        private double height = 5.00;

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="NewProjForm"/> class.
        /// </summary>
        /// <param name="uIDocument"></param>
        public NewProjForm(UIDocument uIDocument)
        {
           uidoc = uIDocument;
           InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Handles the Click event of the button OK control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            /*this.DialogResult = DialogResult.OK;
            Close();*/
            CommandsCreate.CmdCreateNewWall nw = new CommandsCreate.CmdCreateNewWall();
            nw.Execute();
        }

        /// <summary>
        /// Handles the Click event of the button Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the load event of the New Project Form Control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data</param>
        /// 
        private void NewProjForm_Load(object sender, System.EventArgs e)
        {
        
        }

        #endregion 

        #region public methods

        /// <summary>
        /// Gets the information from the user.
        /// </summary>
        /// <returns></returns>

        public NewProj_CmdData GetInformation()
        {
            var information = new NewProj_CmdData()
            {
               /*length = CBLength.Text,
               depth = CBDepth.Text,
               height = CBHeight.Text*/

            };
            return information;
        }

        #endregion
    }
}
// 04 - Revit API - Plugin Essentials - Show Dialog Box and create SketchPlane 6:47
