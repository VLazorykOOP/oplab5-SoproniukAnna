namespace Task1Lab5pr
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Button buttonDraw;
            private System.Windows.Forms.TextBox textBoxX1;
            private System.Windows.Forms.TextBox textBoxY1;
            private System.Windows.Forms.TextBox textBoxX2;
            private System.Windows.Forms.TextBox textBoxY2;
            private System.Windows.Forms.TextBox textBoxVx1;
            private System.Windows.Forms.TextBox textBoxVy1;
            private System.Windows.Forms.TextBox textBoxVx2;
            private System.Windows.Forms.TextBox textBoxVy2;
            private System.Windows.Forms.PictureBox pictureBox1;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxVx1 = new System.Windows.Forms.TextBox();
            this.textBoxVy1 = new System.Windows.Forms.TextBox();
            this.textBoxVx2 = new System.Windows.Forms.TextBox();
            this.textBoxVy2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LX1 = new System.Windows.Forms.Label();
            this.LY1 = new System.Windows.Forms.Label();
            this.LX2 = new System.Windows.Forms.Label();
            this.LY2 = new System.Windows.Forms.Label();
            this.LVX1 = new System.Windows.Forms.Label();
            this.LVY1 = new System.Windows.Forms.Label();
            this.LVX2 = new System.Windows.Forms.Label();
            this.LVY2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(14, 32);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(88, 27);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(108, 32);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(58, 23);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.Text = "100";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(174, 32);
            this.textBoxY1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(58, 23);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.Text = "200";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(239, 32);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(58, 23);
            this.textBoxX2.TabIndex = 3;
            this.textBoxX2.Text = "400";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(304, 32);
            this.textBoxY2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(58, 23);
            this.textBoxY2.TabIndex = 4;
            this.textBoxY2.Text = "200";
            // 
            // textBoxVx1
            // 
            this.textBoxVx1.Location = new System.Drawing.Point(370, 32);
            this.textBoxVx1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVx1.Name = "textBoxVx1";
            this.textBoxVx1.Size = new System.Drawing.Size(58, 23);
            this.textBoxVx1.TabIndex = 5;
            this.textBoxVx1.Text = "150";
            // 
            // textBoxVy1
            // 
            this.textBoxVy1.Location = new System.Drawing.Point(435, 32);
            this.textBoxVy1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVy1.Name = "textBoxVy1";
            this.textBoxVy1.Size = new System.Drawing.Size(58, 23);
            this.textBoxVy1.TabIndex = 6;
            this.textBoxVy1.Text = "-150";
            // 
            // textBoxVx2
            // 
            this.textBoxVx2.Location = new System.Drawing.Point(500, 32);
            this.textBoxVx2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVx2.Name = "textBoxVx2";
            this.textBoxVx2.Size = new System.Drawing.Size(58, 23);
            this.textBoxVx2.TabIndex = 7;
            this.textBoxVx2.Text = "150";
            // 
            // textBoxVy2
            // 
            this.textBoxVy2.Location = new System.Drawing.Point(566, 32);
            this.textBoxVy2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVy2.Name = "textBoxVy2";
            this.textBoxVy2.Size = new System.Drawing.Size(58, 23);
            this.textBoxVy2.TabIndex = 8;
            this.textBoxVy2.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 444);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LX1
            // 
            this.LX1.AutoSize = true;
            this.LX1.Location = new System.Drawing.Point(109, 14);
            this.LX1.Name = "LX1";
            this.LX1.Size = new System.Drawing.Size(20, 15);
            this.LX1.TabIndex = 10;
            this.LX1.Text = "X1";
            // 
            // LY1
            // 
            this.LY1.AutoSize = true;
            this.LY1.Location = new System.Drawing.Point(174, 14);
            this.LY1.Name = "LY1";
            this.LY1.Size = new System.Drawing.Size(20, 15);
            this.LY1.TabIndex = 11;
            this.LY1.Text = "Y1";
            // 
            // LX2
            // 
            this.LX2.AutoSize = true;
            this.LX2.Location = new System.Drawing.Point(239, 14);
            this.LX2.Name = "LX2";
            this.LX2.Size = new System.Drawing.Size(20, 15);
            this.LX2.TabIndex = 12;
            this.LX2.Text = "X2";
            // 
            // LY2
            // 
            this.LY2.AutoSize = true;
            this.LY2.Location = new System.Drawing.Point(304, 14);
            this.LY2.Name = "LY2";
            this.LY2.Size = new System.Drawing.Size(20, 15);
            this.LY2.TabIndex = 13;
            this.LY2.Text = "Y2";
            // 
            // LVX1
            // 
            this.LVX1.AutoSize = true;
            this.LVX1.Location = new System.Drawing.Point(369, 14);
            this.LVX1.Name = "LVX1";
            this.LVX1.Size = new System.Drawing.Size(27, 15);
            this.LVX1.TabIndex = 14;
            this.LVX1.Text = "VX1";
            // 
            // LVY1
            // 
            this.LVY1.AutoSize = true;
            this.LVY1.Location = new System.Drawing.Point(435, 14);
            this.LVY1.Name = "LVY1";
            this.LVY1.Size = new System.Drawing.Size(27, 15);
            this.LVY1.TabIndex = 15;
            this.LVY1.Text = "VY1";
            // 
            // LVX2
            // 
            this.LVX2.AutoSize = true;
            this.LVX2.Location = new System.Drawing.Point(500, 14);
            this.LVX2.Name = "LVX2";
            this.LVX2.Size = new System.Drawing.Size(27, 15);
            this.LVX2.TabIndex = 16;
            this.LVX2.Text = "VX2";
            // 
            // LVY2
            // 
            this.LVY2.AutoSize = true;
            this.LVY2.Location = new System.Drawing.Point(566, 14);
            this.LVY2.Name = "LVY2";
            this.LVY2.Size = new System.Drawing.Size(27, 15);
            this.LVY2.TabIndex = 17;
            this.LVY2.Text = "VY2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.LVY2);
            this.Controls.Add(this.LVX2);
            this.Controls.Add(this.LVY1);
            this.Controls.Add(this.LVX1);
            this.Controls.Add(this.LY2);
            this.Controls.Add(this.LX2);
            this.Controls.Add(this.LY1);
            this.Controls.Add(this.LX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxVy2);
            this.Controls.Add(this.textBoxVx2);
            this.Controls.Add(this.textBoxVy1);
            this.Controls.Add(this.textBoxVx1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.buttonDraw);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Hermite Curve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        private Label LX1;
        private Label LY1;
        private Label LX2;
        private Label LY2;
        private Label LVX1;
        private Label LVY1;
        private Label LVX2;
        private Label LVY2;
    }
    }