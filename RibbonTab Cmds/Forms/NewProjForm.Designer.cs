namespace Hazen_RibbonPanel
{
    partial class NewProjForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.GrpBoxBldgDim = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.LblHeight = new System.Windows.Forms.Label();
            this.CBHeight = new System.Windows.Forms.ComboBox();
            this.LblDepth = new System.Windows.Forms.Label();
            this.CBDepth = new System.Windows.Forms.ComboBox();
            this.LblLength = new System.Windows.Forms.Label();
            this.CBLength = new System.Windows.Forms.ComboBox();
            this.GrpBoxConstType = new System.Windows.Forms.GroupBox();
            this.GrpBoxRoofType = new System.Windows.Forms.GroupBox();
            this.GrpBoxBldgDim.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(114, 530);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 28);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 530);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // GrpBoxBldgDim
            // 
            this.GrpBoxBldgDim.Controls.Add(this.btnClear);
            this.GrpBoxBldgDim.Controls.Add(this.LblHeight);
            this.GrpBoxBldgDim.Controls.Add(this.CBHeight);
            this.GrpBoxBldgDim.Controls.Add(this.LblDepth);
            this.GrpBoxBldgDim.Controls.Add(this.CBDepth);
            this.GrpBoxBldgDim.Controls.Add(this.LblLength);
            this.GrpBoxBldgDim.Controls.Add(this.CBLength);
            this.GrpBoxBldgDim.Location = new System.Drawing.Point(15, 276);
            this.GrpBoxBldgDim.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxBldgDim.Name = "GrpBoxBldgDim";
            this.GrpBoxBldgDim.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxBldgDim.Size = new System.Drawing.Size(319, 246);
            this.GrpBoxBldgDim.TabIndex = 2;
            this.GrpBoxBldgDim.TabStop = false;
            this.GrpBoxBldgDim.Text = "Building Dimensions";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(205, 172);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(9, 153);
            this.LblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(49, 17);
            this.LblHeight.TabIndex = 5;
            this.LblHeight.Text = "Height";
            // 
            // CBHeight
            // 
            this.CBHeight.FormattingEnabled = true;
            this.CBHeight.Location = new System.Drawing.Point(8, 175);
            this.CBHeight.Margin = new System.Windows.Forms.Padding(4);
            this.CBHeight.Name = "CBHeight";
            this.CBHeight.Size = new System.Drawing.Size(160, 24);
            this.CBHeight.TabIndex = 4;
            // 
            // LblDepth
            // 
            this.LblDepth.AutoSize = true;
            this.LblDepth.Location = new System.Drawing.Point(9, 98);
            this.LblDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDepth.Name = "LblDepth";
            this.LblDepth.Size = new System.Drawing.Size(46, 17);
            this.LblDepth.TabIndex = 3;
            this.LblDepth.Text = "Depth";
            // 
            // CBDepth
            // 
            this.CBDepth.FormattingEnabled = true;
            this.CBDepth.Location = new System.Drawing.Point(8, 121);
            this.CBDepth.Margin = new System.Windows.Forms.Padding(4);
            this.CBDepth.Name = "CBDepth";
            this.CBDepth.Size = new System.Drawing.Size(160, 24);
            this.CBDepth.TabIndex = 2;
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(9, 44);
            this.LblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(52, 17);
            this.LblLength.TabIndex = 1;
            this.LblLength.Text = "Length";
            // 
            // CBLength
            // 
            this.CBLength.FormattingEnabled = true;
            this.CBLength.Location = new System.Drawing.Point(8, 66);
            this.CBLength.Margin = new System.Windows.Forms.Padding(4);
            this.CBLength.Name = "CBLength";
            this.CBLength.Size = new System.Drawing.Size(160, 24);
            this.CBLength.TabIndex = 0;
            // 
            // GrpBoxConstType
            // 
            this.GrpBoxConstType.Location = new System.Drawing.Point(16, 15);
            this.GrpBoxConstType.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxConstType.Name = "GrpBoxConstType";
            this.GrpBoxConstType.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxConstType.Size = new System.Drawing.Size(317, 123);
            this.GrpBoxConstType.TabIndex = 3;
            this.GrpBoxConstType.TabStop = false;
            this.GrpBoxConstType.Text = "Construction Type";
            // 
            // GrpBoxRoofType
            // 
            this.GrpBoxRoofType.Location = new System.Drawing.Point(16, 145);
            this.GrpBoxRoofType.Margin = new System.Windows.Forms.Padding(4);
            this.GrpBoxRoofType.Name = "GrpBoxRoofType";
            this.GrpBoxRoofType.Padding = new System.Windows.Forms.Padding(4);
            this.GrpBoxRoofType.Size = new System.Drawing.Size(317, 123);
            this.GrpBoxRoofType.TabIndex = 4;
            this.GrpBoxRoofType.TabStop = false;
            this.GrpBoxRoofType.Text = "Roof Type";
            // 
            // NewProjForm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 563);
            this.Controls.Add(this.GrpBoxRoofType);
            this.Controls.Add(this.GrpBoxConstType);
            this.Controls.Add(this.GrpBoxBldgDim);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewProjForm";
            this.Text = "New Project Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewProjForm_Load);
            this.GrpBoxBldgDim.ResumeLayout(false);
            this.GrpBoxBldgDim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox GrpBoxBldgDim;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.ComboBox CBHeight;
        private System.Windows.Forms.Label LblDepth;
        private System.Windows.Forms.ComboBox CBDepth;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.ComboBox CBLength;
        private System.Windows.Forms.GroupBox GrpBoxConstType;
        private System.Windows.Forms.GroupBox GrpBoxRoofType;
        private System.Windows.Forms.Button btnClear;
    }
}