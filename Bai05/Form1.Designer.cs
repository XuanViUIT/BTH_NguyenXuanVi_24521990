namespace Lab02_Example
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblAns = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            lblRes = new Label();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.Location = new Point(62, 41);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(85, 30);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Number 1";
            // 
            // lblNum2
            // 
            lblNum2.Location = new Point(62, 93);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(85, 30);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Number 2";
            lblNum2.Click += label2_Click;
            // 
            // lblAns
            // 
            lblAns.Location = new Point(62, 262);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(85, 30);
            lblAns.TabIndex = 5;
            lblAns.Text = "Answer";
            lblAns.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(164, 44);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(283, 27);
            txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(164, 93);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(283, 27);
            txtNum2.TabIndex = 7;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ScrollBar;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 12F);
            btnPlus.Location = new Point(77, 161);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 50);
            btnPlus.TabIndex = 9;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ScrollBar;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 12F);
            btnMinus.Location = new Point(191, 161);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 50);
            btnMinus.TabIndex = 10;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ScrollBar;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI", 12F);
            btnMulti.Location = new Point(305, 161);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(60, 50);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ScrollBar;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 12F);
            btnDiv.Location = new Point(419, 161);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(60, 50);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += button4_Click;
            // 
            // lblRes
            // 
            lblRes.BackColor = SystemColors.Window;
            lblRes.Location = new Point(164, 262);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(283, 25);
            lblRes.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRes);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblAns);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblAns;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnDiv;
        private Label lblRes;
    }
}
