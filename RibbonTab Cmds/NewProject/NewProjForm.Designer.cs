namespace B_HelloWorld_RibbonPanel.Forms
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.LblHeight = new System.Windows.Forms.Label();
            this.CBHeight = new System.Windows.Forms.ComboBox();
            this.LblWidth = new System.Windows.Forms.Label();
            this.CBWidth = new System.Windows.Forms.ComboBox();
            this.LblLength = new System.Windows.Forms.Label();
            this.CBLength = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblStartNum = new System.Windows.Forms.Label();
            this.CBStartNum = new System.Windows.Forms.ComboBox();
            this.LblIndexNum = new System.Windows.Forms.Label();
            this.CBIndexNum = new System.Windows.Forms.ComboBox();
            this.LblIndexLetter = new System.Windows.Forms.Label();
            this.CBIndexLetter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(454, 528);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(577, 528);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.LblHeight);
            this.groupBox1.Controls.Add(this.CBHeight);
            this.groupBox1.Controls.Add(this.LblWidth);
            this.groupBox1.Controls.Add(this.CBWidth);
            this.groupBox1.Controls.Add(this.LblLength);
            this.groupBox1.Controls.Add(this.CBLength);
            this.groupBox1.Location = new System.Drawing.Point(15, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Dimensions";
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
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(9, 98);
            this.LblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(44, 17);
            this.LblWidth.TabIndex = 3;
            this.LblWidth.Text = "Width";
            // 
            // CBWidth
            // 
            this.CBWidth.FormattingEnabled = true;
            this.CBWidth.Location = new System.Drawing.Point(8, 121);
            this.CBWidth.Margin = new System.Windows.Forms.Padding(4);
            this.CBWidth.Name = "CBWidth";
            this.CBWidth.Size = new System.Drawing.Size(160, 24);
            this.CBWidth.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(317, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Construction Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 145);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(317, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roof Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblStartNum);
            this.groupBox4.Controls.Add(this.CBStartNum);
            this.groupBox4.Controls.Add(this.LblIndexNum);
            this.groupBox4.Controls.Add(this.CBIndexNum);
            this.groupBox4.Controls.Add(this.LblIndexLetter);
            this.groupBox4.Controls.Add(this.CBIndexLetter);
            this.groupBox4.Location = new System.Drawing.Point(357, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 507);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sheetset";
            // 
            // LblStartNum
            // 
            this.LblStartNum.AutoSize = true;
            this.LblStartNum.Location = new System.Drawing.Point(211, 30);
            this.LblStartNum.Name = "LblStartNum";
            this.LblStartNum.Size = new System.Drawing.Size(90, 17);
            this.LblStartNum.TabIndex = 5;
            this.LblStartNum.Text = "Start number";
            // 
            // CBStartNum
            // 
            this.CBStartNum.FormattingEnabled = true;
            this.CBStartNum.Location = new System.Drawing.Point(210, 53);
            this.CBStartNum.Name = "CBStartNum";
            this.CBStartNum.Size = new System.Drawing.Size(94, 24);
            this.CBStartNum.TabIndex = 4;
            // 
            // LblIndexNum
            // 
            this.LblIndexNum.AutoSize = true;
            this.LblIndexNum.Location = new System.Drawing.Point(101, 30);
            this.LblIndexNum.Name = "LblIndexNum";
            this.LblIndexNum.Size = new System.Drawing.Size(93, 17);
            this.LblIndexNum.TabIndex = 3;
            this.LblIndexNum.Text = "Index number";
            // 
            // CBIndexNum
            // 
            this.CBIndexNum.FormattingEnabled = true;
            this.CBIndexNum.Location = new System.Drawing.Point(100, 53);
            this.CBIndexNum.Name = "CBIndexNum";
            this.CBIndexNum.Size = new System.Drawing.Size(94, 24);
            this.CBIndexNum.TabIndex = 2;
            // 
            // LblIndexLetter
            // 
            this.LblIndexLetter.AutoSize = true;
            this.LblIndexLetter.Location = new System.Drawing.Point(7, 30);
            this.LblIndexLetter.Name = "LblIndexLetter";
            this.LblIndexLetter.Size = new System.Drawing.Size(77, 17);
            this.LblIndexLetter.TabIndex = 1;
            this.LblIndexLetter.Text = "Index letter";
            // 
            // CBIndexLetter
            // 
            this.CBIndexLetter.FormattingEnabled = true;
            this.CBIndexLetter.Location = new System.Drawing.Point(6, 53);
            this.CBIndexLetter.Name = "CBIndexLetter";
            this.CBIndexLetter.Size = new System.Drawing.Size(78, 24);
            this.CBIndexLetter.TabIndex = 0;
            // 
            // NewProjForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(689, 563);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewProjForm";
            this.Text = "New Project Form";
            this.Load += new System.EventHandler(this.NewProjForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.ComboBox CBHeight;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.ComboBox CBWidth;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.ComboBox CBLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblStartNum;
        private System.Windows.Forms.ComboBox CBStartNum;
        private System.Windows.Forms.Label LblIndexNum;
        private System.Windows.Forms.ComboBox CBIndexNum;
        private System.Windows.Forms.Label LblIndexLetter;
        private System.Windows.Forms.ComboBox CBIndexLetter;
    }
}