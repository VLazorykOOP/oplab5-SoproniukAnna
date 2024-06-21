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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(14, 14);
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
            this.textBoxX1.Location = new System.Drawing.Point(108, 16);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(58, 23);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.Text = "X1";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(174, 16);
            this.textBoxY1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(58, 23);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.Text = "Y1";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(239, 16);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(58, 23);
            this.textBoxX2.TabIndex = 3;
            this.textBoxX2.Text = "X2";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(304, 16);
            this.textBoxY2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(58, 23);
            this.textBoxY2.TabIndex = 4;
            this.textBoxY2.Text = "Y2";
            // 
            // textBoxVx1
            // 
            this.textBoxVx1.Location = new System.Drawing.Point(370, 16);
            this.textBoxVx1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVx1.Name = "textBoxVx1";
            this.textBoxVx1.Size = new System.Drawing.Size(58, 23);
            this.textBoxVx1.TabIndex = 5;
            this.textBoxVx1.Text = "Vx1";
            // 
            // textBoxVy1
            // 
            this.textBoxVy1.Location = new System.Drawing.Point(435, 16);
            this.textBoxVy1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVy1.Name = "textBoxVy1";
            this.textBoxVy1.Size = new System.Drawing.Size(58, 23);
            this.textBoxVy1.TabIndex = 6;
            this.textBoxVy1.Text = "Vy1";
            // 
            // textBoxVx2
            // 
            this.textBoxVx2.Location = new System.Drawing.Point(500, 16);
            this.textBoxVx2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVx2.Name = "textBoxVx2";
            this.textBoxVx2.Size = new System.Drawing.Size(58, 23);
            this.textBoxVx2.TabIndex = 7;
            this.textBoxVx2.Text = "Vx2";
            // 
            // textBoxVy2
            // 
            this.textBoxVy2.Location = new System.Drawing.Point(566, 16);
            this.textBoxVy2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVy2.Name = "textBoxVy2";
            this.textBoxVy2.Size = new System.Drawing.Size(58, 23);
            this.textBoxVy2.TabIndex = 8;
            this.textBoxVy2.Text = "Vy2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 458);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
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
        }
    }