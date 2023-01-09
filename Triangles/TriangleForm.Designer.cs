namespace Triangles
{
    partial class TriangleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SideLengthA = new System.Windows.Forms.TextBox();
            this.SideLengthB = new System.Windows.Forms.TextBox();
            this.SideLengthC = new System.Windows.Forms.TextBox();
            this.AngleA = new System.Windows.Forms.Label();
            this.AngleB = new System.Windows.Forms.Label();
            this.AngleC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Side a length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side b length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side c length:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 113);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 15);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Enter side lengths";
            // 
            // SideLengthA
            // 
            this.SideLengthA.Location = new System.Drawing.Point(96, 12);
            this.SideLengthA.Name = "SideLengthA";
            this.SideLengthA.Size = new System.Drawing.Size(154, 23);
            this.SideLengthA.TabIndex = 7;
            this.SideLengthA.TextChanged += new System.EventHandler(this.ProcessInput);
            this.SideLengthA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.SideLengthA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // SideLengthB
            // 
            this.SideLengthB.Location = new System.Drawing.Point(96, 41);
            this.SideLengthB.Name = "SideLengthB";
            this.SideLengthB.Size = new System.Drawing.Size(154, 23);
            this.SideLengthB.TabIndex = 8;
            this.SideLengthB.TextChanged += new System.EventHandler(this.ProcessInput);
            this.SideLengthB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.SideLengthB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // SideLengthC
            // 
            this.SideLengthC.Location = new System.Drawing.Point(96, 70);
            this.SideLengthC.Name = "SideLengthC";
            this.SideLengthC.Size = new System.Drawing.Size(154, 23);
            this.SideLengthC.TabIndex = 9;
            this.SideLengthC.TextChanged += new System.EventHandler(this.ProcessInput);
            this.SideLengthC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.SideLengthC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // AngleA
            // 
            this.AngleA.AutoSize = true;
            this.AngleA.Location = new System.Drawing.Point(12, 137);
            this.AngleA.Name = "AngleA";
            this.AngleA.Size = new System.Drawing.Size(0, 15);
            this.AngleA.TabIndex = 10;
            // 
            // AngleB
            // 
            this.AngleB.AutoSize = true;
            this.AngleB.Location = new System.Drawing.Point(84, 137);
            this.AngleB.Name = "AngleB";
            this.AngleB.Size = new System.Drawing.Size(0, 15);
            this.AngleB.TabIndex = 11;
            // 
            // AngleC
            // 
            this.AngleC.AutoSize = true;
            this.AngleC.Location = new System.Drawing.Point(156, 137);
            this.AngleC.Name = "AngleC";
            this.AngleC.Size = new System.Drawing.Size(0, 15);
            this.AngleC.TabIndex = 12;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 221);
            this.Controls.Add(this.AngleC);
            this.Controls.Add(this.AngleB);
            this.Controls.Add(this.AngleA);
            this.Controls.Add(this.SideLengthC);
            this.Controls.Add(this.SideLengthB);
            this.Controls.Add(this.SideLengthA);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TriangleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label OutputLabel;
        private TextBox SideLengthA;
        private TextBox SideLengthB;
        private TextBox SideLengthC;
        private Label AngleA;
        private Label AngleB;
        private Label AngleC;
    }
}