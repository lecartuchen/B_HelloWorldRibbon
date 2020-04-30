namespace B_HelloWorld_RibbonPanel
{
    partial class NewSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpBxSheetList = new System.Windows.Forms.GroupBox();
            this.LblNewSheet = new System.Windows.Forms.Label();
            this.CmbBxNewSheet = new System.Windows.Forms.ComboBox();
            this.ChkBxRCPlan = new System.Windows.Forms.CheckBox();
            this.ChkBxRoofPlan = new System.Windows.Forms.CheckBox();
            this.ChkBxGroundFloor = new System.Windows.Forms.CheckBox();
            this.GrpBxSheetList.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(124, 252);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(205, 252);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // GrpBxSheetList
            // 
            this.GrpBxSheetList.Controls.Add(this.LblNewSheet);
            this.GrpBxSheetList.Controls.Add(this.CmbBxNewSheet);
            this.GrpBxSheetList.Controls.Add(this.ChkBxRCPlan);
            this.GrpBxSheetList.Controls.Add(this.ChkBxRoofPlan);
            this.GrpBxSheetList.Controls.Add(this.ChkBxGroundFloor);
            this.GrpBxSheetList.Location = new System.Drawing.Point(12, 12);
            this.GrpBxSheetList.Name = "GrpBxSheetList";
            this.GrpBxSheetList.Size = new System.Drawing.Size(268, 234);
            this.GrpBxSheetList.TabIndex = 2;
            this.GrpBxSheetList.TabStop = false;
            this.GrpBxSheetList.Text = "Sheet List";
            // 
            // LblNewSheet
            // 
            this.LblNewSheet.AutoSize = true;
            this.LblNewSheet.Location = new System.Drawing.Point(15, 170);
            this.LblNewSheet.Name = "LblNewSheet";
            this.LblNewSheet.Size = new System.Drawing.Size(76, 17);
            this.LblNewSheet.TabIndex = 4;
            this.LblNewSheet.Text = "New Sheet";
            // 
            // CmbBxNewSheet
            // 
            this.CmbBxNewSheet.FormattingEnabled = true;
            this.CmbBxNewSheet.Location = new System.Drawing.Point(15, 193);
            this.CmbBxNewSheet.Name = "CmbBxNewSheet";
            this.CmbBxNewSheet.Size = new System.Drawing.Size(235, 24);
            this.CmbBxNewSheet.TabIndex = 3;
            this.CmbBxNewSheet.Text = "Type new sheet";
            this.CmbBxNewSheet.SelectedIndexChanged += new System.EventHandler(this.CmbBxNewSheet_SelectedIndexChanged);
            // 
            // ChkBxRCPlan
            // 
            this.ChkBxRCPlan.AutoSize = true;
            this.ChkBxRCPlan.Checked = true;
            this.ChkBxRCPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBxRCPlan.Location = new System.Drawing.Point(15, 115);
            this.ChkBxRCPlan.Name = "ChkBxRCPlan";
            this.ChkBxRCPlan.Size = new System.Drawing.Size(90, 21);
            this.ChkBxRCPlan.TabIndex = 2;
            this.ChkBxRCPlan.Text = "RCP Plan";
            this.ChkBxRCPlan.UseVisualStyleBackColor = true;
            // 
            // ChkBxRoofPlan
            // 
            this.ChkBxRoofPlan.AutoSize = true;
            this.ChkBxRoofPlan.Checked = true;
            this.ChkBxRoofPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBxRoofPlan.Location = new System.Drawing.Point(15, 73);
            this.ChkBxRoofPlan.Name = "ChkBxRoofPlan";
            this.ChkBxRoofPlan.Size = new System.Drawing.Size(92, 21);
            this.ChkBxRoofPlan.TabIndex = 1;
            this.ChkBxRoofPlan.Text = "Roof Plan";
            this.ChkBxRoofPlan.UseVisualStyleBackColor = true;
            // 
            // ChkBxGroundFloor
            // 
            this.ChkBxGroundFloor.AutoSize = true;
            this.ChkBxGroundFloor.Checked = true;
            this.ChkBxGroundFloor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBxGroundFloor.Location = new System.Drawing.Point(15, 31);
            this.ChkBxGroundFloor.Name = "ChkBxGroundFloor";
            this.ChkBxGroundFloor.Size = new System.Drawing.Size(94, 21);
            this.ChkBxGroundFloor.TabIndex = 0;
            this.ChkBxGroundFloor.Text = "Floor Plan";
            this.ChkBxGroundFloor.UseVisualStyleBackColor = true;
            // 
            // NewSheetForm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(292, 283);
            this.Controls.Add(this.GrpBxSheetList);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "NewSheetForm";
            this.Text = "Sheetlist Settings";
            this.Load += new System.EventHandler(this.NewSheetForm_Load);
            this.GrpBxSheetList.ResumeLayout(false);
            this.GrpBxSheetList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GrpBxSheetList;
        private System.Windows.Forms.CheckBox ChkBxRCPlan;
        private System.Windows.Forms.CheckBox ChkBxRoofPlan;
        private System.Windows.Forms.CheckBox ChkBxGroundFloor;
        private System.Windows.Forms.ComboBox CmbBxNewSheet;
        private System.Windows.Forms.Label LblNewSheet;
    }
}