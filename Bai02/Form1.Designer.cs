namespace Bai02
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
            btnPaint = new Button();
            lblPaintEvent = new Label();
            lblX = new Label();
            lblY = new Label();
            SuspendLayout();
            // 
            // btnPaint
            // 
            btnPaint.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaint.Location = new Point(-5, 0);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(132, 50);
            btnPaint.TabIndex = 0;
            btnPaint.Text = "Paint";
            btnPaint.TextAlign = ContentAlignment.TopCenter;
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += button1_Click;
            // 
            // lblPaintEvent
            // 
            lblPaintEvent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaintEvent.Location = new Point(271, 166);
            lblPaintEvent.Name = "lblPaintEvent";
            lblPaintEvent.Size = new Size(150, 63);
            lblPaintEvent.TabIndex = 1;
            lblPaintEvent.Text = "PAINT EVENT";
            lblPaintEvent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Dock = DockStyle.Bottom;
            lblX.Location = new Point(0, 430);
            lblX.Name = "lblX";
            lblX.Size = new Size(0, 20);
            lblX.TabIndex = 2;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(56, 430);
            lblY.Name = "lblY";
            lblY.Size = new Size(0, 20);
            lblY.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(lblPaintEvent);
            Controls.Add(btnPaint);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPaint;
        private Label lblPaintEvent;
        private Label lblX;
        private Label lblY;
    }
}
