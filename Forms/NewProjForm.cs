namespace B_HelloWorld_RibbonPanel.Forms
{
    using System;
    using System.Windows.Forms;
    using Autodesk.Revit.UI;
    /// New Project Data acquisition form.
    /// </summary>

    public partial class NewProjForm : Form
    {
        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>.
        /// </summary>
        #region Private Members
        public UIDocument uidoc = null;

        public static object doc { get; internal set; }
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
        }

        public NewProjForm()
        {
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles the Load event of the NewProjForm control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>
        private void NewProjForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the button OK control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the button Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion 

        #region public methods

        #endregion
    }
}
// 04 - Revit API - Plugin Essentials - Show Dialog Box and create SketchPlane 6:47
