namespace Hazen_RibbonPanel

{
    using Autodesk.Revit.UI;

    /// <summary>
    /// Information and Data Model for command <see cref="NewProj_CmdData"/> to execute.
    /// </summary>
    public class NewProj_CmdData
    {
        #region Public properties

        public bool Function { get; set; }

        public bool Name { get; set; }

        #endregion
    }
}
