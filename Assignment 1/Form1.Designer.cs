namespace Assignment_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFName = new Label();
            lblLName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtHours = new TextBox();
            lblHours = new Label();
            btnSum = new Button();
            btnClear = new Button();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(98, 45);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(80, 20);
            lblFName.TabIndex = 0;
            lblFName.Text = "&First Name";
            lblFName.Click += label1_Click;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(357, 45);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(79, 20);
            lblLName.TabIndex = 2;
            lblLName.Text = "&Last name:";
            lblLName.Click += label1_Click_1;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(74, 89);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(125, 27);
            txtFName.TabIndex = 1;
            txtFName.TextChanged += txtBox1_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(333, 89);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 27);
            txtLName.TabIndex = 3;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(589, 89);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 5;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(599, 45);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(106, 20);
            lblHours.TabIndex = 4;
            lblHours.Text = "&Hours Worked:";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(74, 195);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(94, 29);
            btnSum.TabIndex = 6;
            btnSum.Text = "&Summarize";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += sumBtn_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(207, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += clrBtn_Click;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Font = new Font("Times New Roman", 14F);
            lblSummary.Location = new Point(98, 293);
            lblSummary.MaximumSize = new Size(200, 500);
            lblSummary.MinimumSize = new Size(600, 100);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(600, 100);
            lblSummary.TabIndex = 8;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            lblSummary.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSummary);
            Controls.Add(btnClear);
            Controls.Add(btnSum);
            Controls.Add(lblHours);
            Controls.Add(txtHours);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "Form1";
            Text = "Assignment 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFName;
        private Label lblLName;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtHours;
        private Label lblHours;
        private Button btnSum;
        private Button btnClear;
        private Label lblSummary;
    }
}
