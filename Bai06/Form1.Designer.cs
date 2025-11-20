namespace Bai06
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
            components = new System.ComponentModel.Container();
            txtDisplay = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnMinus = new Button();
            btnSqt = new Button();
            btnModule = new Button();
            btnEqual = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnM_Plus = new Button();
            btnMS = new Button();
            btnNum0 = new Button();
            btnPlus_div_minus = new Button();
            btnDem = new Button();
            btnPlus = new Button();
            btn1divx = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(69, 34);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(488, 38);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(121, 110);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(124, 47);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(278, 110);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(124, 47);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(433, 110);
            btnC.Name = "btnC";
            btnC.Size = new Size(124, 47);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(121, 211);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(94, 29);
            btnNum7.TabIndex = 4;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNumber_Click;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(248, 211);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(94, 29);
            btnNum8.TabIndex = 5;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNumber_Click;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(364, 211);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(94, 29);
            btnNum9.TabIndex = 6;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNumber_Click;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(121, 270);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(94, 29);
            btnNum4.TabIndex = 7;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNumber_Click;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(248, 270);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(94, 29);
            btnNum5.TabIndex = 8;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNumber_Click;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(364, 270);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(94, 29);
            btnNum6.TabIndex = 9;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNumber_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 10.2F);
            btnDiv.Location = new Point(474, 211);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 29);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "/";
            btnDiv.TextAlign = ContentAlignment.TopCenter;
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnOperator_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 10.2F);
            btnMulti.Location = new Point(474, 270);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(94, 29);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "*";
            btnMulti.TextAlign = ContentAlignment.TopCenter;
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnOperator_Click;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(121, 306);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(94, 29);
            btnNum1.TabIndex = 12;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNumber_Click;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(248, 306);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(94, 29);
            btnNum2.TabIndex = 13;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNumber_Click;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(364, 306);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(94, 29);
            btnNum3.TabIndex = 14;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNumber_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 10.2F);
            btnMinus.Location = new Point(474, 306);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 29);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.TextAlign = ContentAlignment.TopCenter;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnSqt
            // 
            btnSqt.Location = new Point(574, 211);
            btnSqt.Name = "btnSqt";
            btnSqt.Size = new Size(94, 29);
            btnSqt.TabIndex = 16;
            btnSqt.Text = "sqt";
            btnSqt.UseVisualStyleBackColor = true;
            // 
            // btnModule
            // 
            btnModule.Location = new Point(597, 271);
            btnModule.Name = "btnModule";
            btnModule.Size = new Size(94, 29);
            btnModule.TabIndex = 17;
            btnModule.Text = "%";
            btnModule.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(597, 341);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(94, 29);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(12, 211);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(94, 29);
            btnMC.TabIndex = 19;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(12, 271);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(94, 29);
            btnMR.TabIndex = 20;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            // 
            // btnM_Plus
            // 
            btnM_Plus.Location = new Point(12, 335);
            btnM_Plus.Name = "btnM_Plus";
            btnM_Plus.Size = new Size(94, 29);
            btnM_Plus.TabIndex = 21;
            btnM_Plus.Text = "M+";
            btnM_Plus.UseVisualStyleBackColor = true;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(12, 306);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(94, 29);
            btnMS.TabIndex = 22;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(121, 341);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(94, 29);
            btnNum0.TabIndex = 23;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNumber_Click;
            // 
            // btnPlus_div_minus
            // 
            btnPlus_div_minus.Location = new Point(248, 341);
            btnPlus_div_minus.Name = "btnPlus_div_minus";
            btnPlus_div_minus.Size = new Size(94, 29);
            btnPlus_div_minus.TabIndex = 24;
            btnPlus_div_minus.Text = "+/-";
            btnPlus_div_minus.UseVisualStyleBackColor = true;
            // 
            // btnDem
            // 
            btnDem.Location = new Point(364, 341);
            btnDem.Name = "btnDem";
            btnDem.Size = new Size(94, 29);
            btnDem.TabIndex = 25;
            btnDem.Text = ".";
            btnDem.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 10.2F);
            btnPlus.Location = new Point(474, 341);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 29);
            btnPlus.TabIndex = 26;
            btnPlus.Text = "+";
            btnPlus.TextAlign = ContentAlignment.TopCenter;
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperator_Click;
            // 
            // btn1divx
            // 
            btn1divx.Location = new Point(597, 306);
            btn1divx.Name = "btn1divx";
            btn1divx.Size = new Size(94, 29);
            btn1divx.TabIndex = 27;
            btn1divx.Text = "1/x";
            btn1divx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 374);
            Controls.Add(btn1divx);
            Controls.Add(btnPlus);
            Controls.Add(btnDem);
            Controls.Add(btnPlus_div_minus);
            Controls.Add(btnNum0);
            Controls.Add(btnMS);
            Controls.Add(btnM_Plus);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnEqual);
            Controls.Add(btnModule);
            Controls.Add(btnSqt);
            Controls.Add(btnMinus);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnMulti);
            Controls.Add(btnDiv);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Click += btnNumber_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnC;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnMinus;
        private Button btnSqt;
        private Button btnModule;
        private Button btnEqual;
        private Button btnMC;
        private Button btnMR;
        private Button btnM_Plus;
        private Button btnMS;
        private Button btnNum0;
        private Button btnPlus_div_minus;
        private Button btnDem;
        private Button btnPlus;
        private Button btn1divx;
    }
}
