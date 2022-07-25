namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public int COUNT = 1;
        private void StartButton_Click(object sender, EventArgs e)
        {
            
            //hides button
            StartButton.Visible = false;

            createGrid(num);


        }

        public int num = 45;
        public float PlayerX = 0;
        public float PlayerY = 0;



        private void createGrid(int num)
        {
            //creates pen
            Graphics gr = GameGrid.CreateGraphics();
            Graphics snake = GameGrid.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Arial", 10);
            int lines = 10;
            float x = 0f;
            float y = 0f;
            float xSpace = GameGrid.Width / lines;
            float ySpace = GameGrid.Height / lines;
            //gr.Clear(Color.White);

            if (COUNT == 1)
            {
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

                x = 0f;
                y = 0f;
                int counter = 1;

            
                for (int j = 0; j < lines; j++)
                {
                    for (int k = 0; k < lines; k++)
                    {
                        if (counter == num)
                        {
                            gr.DrawString(Convert.ToString(counter), myFont, Brushes.Black, x, y);
                            snake.DrawEllipse(myPen, x + 25, y + 5, 25, 25);
                            PlayerX = x + 25;
                            PlayerY = y + 5;

                        }
                        if (counter != num)
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

            if (COUNT != 1)
            {

                snake.DrawEllipse(myPen, PlayerX, PlayerY, 25, 25);

            }
            COUNT++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Up) { CurrentDirection = "Up"; }
            if (e.KeyCode == Keys.Down) { CurrentDirection = "Down"; }
            if (e.KeyCode == Keys.Left) { CurrentDirection = "Left"; }
            if (e.KeyCode == Keys.Right) { CurrentDirection = "Right"; }


        }


        public string CurrentDirection = "None";
        private void SnakeDirection_Tick(object sender, EventArgs e)
        {
            if (CurrentDirection == "Up") { PlayerY -= 25; createGrid(0); }
            if (CurrentDirection == "Down") { PlayerY += 25; createGrid(0); }
            if (CurrentDirection == "Left") { PlayerX -= 25; createGrid(0); }
            if (CurrentDirection == "Right") { PlayerX += 25; createGrid(0); }
        }
    }
}
