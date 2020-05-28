namespace Hazen_RibbonPanel

{
    using Autodesk.Revit.DB;

    /// <summary>
    /// Information and Data Model for command <see cref="NewProj_Cmd"/> to execute.
    /// </summary>
    public class NewProj_CmdData
    {
        #region Public properties

        /// <summary>
        /// Gets or sets the boolean values indicating weather this <see cref="NewProj_CmdData"/> should create the indicated elements.
        /// </summary>
        /// <value>
        /// <c>true</c> if function; otherwise <c>false</c>
        /// </value>

        public double CBLength { get; set; }

        public double CBDepth { get; set; }

        public double CBHeight { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="NewProj_CmdData"/>
        /// </summary>
        public NewProj_CmdData()
        {

        }

        #endregion
    }
}
