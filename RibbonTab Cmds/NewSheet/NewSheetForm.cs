namespace Hazen_RibbonPanel
{
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    /// <summary>
    /// New Sheet data adquisition Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"
    public partial class NewSheetForm : System.Windows.Forms.Form
    {
        #region Private Members

        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>
        /// </summary>

        private UIDocument uidoc = null;

        /// <summary>
        /// The private text type identifier.
        /// </summary>
        private ElementId newSheetNameId = null;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of <see cref="NewSheetForm"/> class.
        /// </summary>
        /// <param name="uIDocument">The u i document</param>

        public NewSheetForm(UIDocument uIDocument)
        {
            uidoc = uIDocument;
            InitializeComponent();
        }
        #endregion

        #region Events

        /// <summary>
        /// Handles the Click event of the BtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data</param>
        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the BtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data</param>
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Load event of the New Sheet Form control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data</param>
        private void NewSheetForm_Load(object sender, System.EventArgs e)
        {
            PopulateTextNoteTypeList();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbBxNewSheet control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="System.EventArgs"/> contaning the event data</param>
        private void CmbBxNewSheet_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            newSheetNameId = ((KeyValuePair<string, ElementId>)CmbBxNewSheet.SelectedItem).Value;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the information from the user.
        /// </summary>
        /// <returns></returns>

        public NewSheet_CmdData GetInformation()
        {
            var information = new NewSheet_CmdData()
            {
                FloorPlan = ChkBxGroundFloor.Checked,
                RoofPlan = ChkBxRoofPlan.Checked,
                RCPlan = ChkBxRCPlan.Checked,
                NewSheetName = newSheetNameId
            };
            return information;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populates the text note type list
        /// Rework to populate the sheetlist selected by the user. Rename the function and variables accordingly.
        /// </summary>
        private void PopulateTextNoteTypeList()
        {
            var doc = uidoc.Document;

            // Gets all the text Element types in the project.
            var allTextElementTypes = new FilteredElementCollector(doc).OfClass(typeof(TextElementType));

            var list = new List<KeyValuePair<string, ElementId>>();

            foreach (var item in allTextElementTypes)
                list.Add(new KeyValuePair<string, ElementId>(item.Name, item.Id));

            CmbBxNewSheet.DataSource = null;
            CmbBxNewSheet.DataSource = new BindingSource(list, null);
            CmbBxNewSheet.DisplayMember = "Key";
            CmbBxNewSheet.ValueMember = "Value";
        }
        #endregion
    }
}
