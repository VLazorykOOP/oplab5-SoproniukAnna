namespace lab5pr
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.PictureBox pictureBoxFractal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.pictureBoxFractal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).BeginInit();
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
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(108, 14);
            this.textBoxOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(116, 23);
            this.textBoxOrder.TabIndex = 1;
            this.textBoxOrder.Text = "4";
            // 
            // pictureBoxFractal
            // 
            this.pictureBoxFractal.Location = new System.Drawing.Point(14, 47);
            this.pictureBoxFractal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxFractal.Name = "pictureBoxFractal";
            this.pictureBoxFractal.Size = new System.Drawing.Size(905, 458);
            this.pictureBoxFractal.TabIndex = 2;
            this.pictureBoxFractal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pictureBoxFractal);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.buttonDraw);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Dandelion Fractal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFractal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}