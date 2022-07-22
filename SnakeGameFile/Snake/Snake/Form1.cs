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
            Font myFont = new Font("Arial", 10);
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

            string S = SNAKE();
            x = 0f;
            y = 0f;
            int counter = 1;
            for (int j = 0; j < lines; j++)
            {
                for (int k = 0; k < lines; k++)
                {
                    if (counter == 45)
                    {
                        gr.DrawString(S, myFont, Brushes.Black, x, y);
                    }
                    if (counter != 45)
                    {
                        gr.DrawString(Convert.ToString(counter), myFont, Brushes.Black, x, y);
                    }
                    x += xSpace;
                    counter++;

                }
                y += ySpace;
                x = 0;
            }
        }

        public string SNAKE()
        {
            string snake = "Snake";
            return snake;
        }
    }
}