namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Graphics gr = GameGrid.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black,1);
            int lines = 9;
            float x = 0f;
            float y = 0f;
            float xSpace = GameGrid.Width / lines;
            float ySpace = GameGrid.Height / lines;

            for (int i = 0; i < lines; i++)
            {
                gr.DrawLine(myPen,x,y,x,GameGrid.Height);
                x += xSpace;
            }
        }

    }
}