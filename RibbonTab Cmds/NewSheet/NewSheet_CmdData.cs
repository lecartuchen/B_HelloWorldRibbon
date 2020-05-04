namespace B_HelloWorld_RibbonPanel
{
    using Autodesk.Revit.DB;

    /// <summary>
    /// Information and Data model for command <see cref="NewSheet_Cmd"/> to execute.
    /// </summary>
    public class NewSheet_CmdData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the boolean values indicating weather this <see cref="NewSheet_CmdData"/> should create the indicated sheets.
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise <c>false</c>
        /// </value>

        public bool FloorPlan { get; set; }
        public bool RoofPlan { get; set; }
        public bool RCPlan { get; set; }

        /// <summary>
        /// Gets or sets the New Sheet name. <see cref="ElementId"/>
        /// </summary>
        /// <value>
        /// The New Sheet name.
        /// </value>
        public ElementId NewSheetName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="NewSheet_CmdData"/>
        /// </summary>
        public NewSheet_CmdData()
        {
           
        }

        #endregion
    }
}
