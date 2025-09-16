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
            fNameLbl = new Label();
            lNameLbl = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtHours = new TextBox();
            label1 = new Label();
            sumBtn = new Button();
            clrBtn = new Button();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // fNameLbl
            // 
            fNameLbl.AutoSize = true;
            fNameLbl.Location = new Point(98, 45);
            fNameLbl.Name = "fNameLbl";
            fNameLbl.Size = new Size(80, 20);
            fNameLbl.TabIndex = 0;
            fNameLbl.Text = "&First Name";
            fNameLbl.Click += label1_Click;
            // 
            // lNameLbl
            // 
            lNameLbl.AutoSize = true;
            lNameLbl.Location = new Point(357, 45);
            lNameLbl.Name = "lNameLbl";
            lNameLbl.Size = new Size(79, 20);
            lNameLbl.TabIndex = 2;
            lNameLbl.Text = "&Last name:";
            lNameLbl.Click += label1_Click_1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "&Hours Worked:";
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(74, 195);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(94, 29);
            sumBtn.TabIndex = 6;
            sumBtn.Text = "&Summarize";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += sumBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(207, 195);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(94, 29);
            clrBtn.TabIndex = 7;
            clrBtn.Text = "&Clear";
            clrBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
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
            Controls.Add(clrBtn);
            Controls.Add(sumBtn);
            Controls.Add(label1);
            Controls.Add(txtHours);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lNameLbl);
            Controls.Add(fNameLbl);
            Name = "Form1";
            Text = "Assignment 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fNameLbl;
        private Label lNameLbl;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtHours;
        private Label label1;
        private Button sumBtn;
        private Button clrBtn;
        private Label lblSummary;
    }
}
