namespace OOP
{
    public partial class Form1 : Form
    {

        List<Shape> shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Shape newS = null;
            Shape newSS = null;

            newS = new Line(Color.Black, 5, new Point(50, 100), new Point(100, 100));
            //   newSS = new RectangleX(Color.Black, 5, new Point(50, 100), 50,100);
            newSS = new Ellipse(Color.Black, 5, new Point(50, 100), 50, 100);
            pictureBox1.Invalidate();
            shapes.Add(newS);
            shapes.Add(newSS);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape newsh in shapes) {
                newsh.Draw(e.Graphics);
            }
        }
    }
}
