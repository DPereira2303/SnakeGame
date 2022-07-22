namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //hides button
            StartButton.Visible = false;
            

            //creates pen
            Graphics gr = GameGrid.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            int lines = 10;
            float x = 0f;
            float y = 0f;
            float xSpace = GameGrid.Width / lines;
            float ySpace = GameGrid.Height / lines;

            //vertical lines
            for (int i = 0; i < lines; i++)
            {
                gr.DrawLine(myPen, x, y, x, GameGrid.Height);
                x += xSpace;
            }

            //horizontal lines
            x = 0f;
            for (int i = 0; i < lines; i++)
            {
                gr.DrawLine(myPen, x, y, GameGrid.Width, y);
                y += ySpace;
            }
        }
    }
}