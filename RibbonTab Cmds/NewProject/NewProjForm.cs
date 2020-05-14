namespace Hazen_RibbonPanel.Forms
{
    using System;
    using System.Windows.Forms;
    using Autodesk.Revit.UI;
    /// New Project Data acquisition form.
    /// </summary>

    public partial class NewProjForm : Form
    {
        #region Private Members

        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>.
        /// </summary>

        private UIDocument uidoc = null;

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
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the button Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The see <see cref="System.EventArgs"/> instance containing the event data</param>
        private void BtnCancel_Click(object sender, EventArgs e)
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
