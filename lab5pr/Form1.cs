namespace lab5pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int order;

            if (int.TryParse(textBoxOrder.Text, out order))
            {
                Bitmap bitmap = new Bitmap(pictureBoxFractal.Width, pictureBoxFractal.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);
                    float x1 = 450, y1 = 400, x2 = 450, y2 = 200;
                    int cR = 135, cG = 206, cB = 235;
                    DrawDandelion(g, x1, y1, x2, y2, order, cR, cG, cB);
                }
                pictureBoxFractal.Image = bitmap;
            }
            else
            {
                MessageBox.Show("Please enter a valid order.");
            }
        }

        private void DrawDandelion(Graphics g, float x1, float y1, float x2, float y2, int Num, int cR, int cG, int cB)
        {
            float dx, dy, xx, yy;
            float[] x = new float[6];
            float[] y = new float[6];
            Pen pen = new Pen(Color.FromArgb(cR, cG, cB));
            g.DrawLine(pen, x1, y1, x2, y2);

            if (Num > 0)
            {
                dx = x2 - x1;
                dy = y2 - y1;
                x[0] = x1 + 0.6f * dx;
                y[0] = y1 + 0.6f * dy;

                for (int i = 0; i < 6; i++)
                {
                    xx = (x[0] - x2) * (float)Math.Cos(i * Math.PI / 3.0) - (y[0] - y2) * (float)Math.Sin(i * Math.PI / 3.0) + x2;
                    yy = (x[0] - x2) * (float)Math.Sin(i * Math.PI / 3.0) + (y[0] - y2) * (float)Math.Cos(i * Math.PI / 3.0) + y2;
                    DrawDandelion(g, x2, y2, xx, yy, Num - 1, cR, cG, cB);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}