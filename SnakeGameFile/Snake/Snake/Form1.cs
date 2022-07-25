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
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Arial", 10);
            int lines = 10;
            float x = 0f;
            float y = 0f;
            float xSpace = GameGrid.Width / lines;
            float ySpace = GameGrid.Height / lines;
            gr.Clear(Color.White);

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

            if (COUNT == 1)
            {
                for (int j = 0; j < lines; j++)
                {
                    for (int k = 0; k < lines; k++)
                    {
                        if (counter == num)
                        {
                            gr.DrawString(Convert.ToString(counter), myFont, Brushes.Black, x, y);
                            gr.DrawEllipse(myPen, x + 25, y + 5, 25, 25);
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
                for (int j = 0; j < lines; j++)
                {
                    for (int k = 0; k < lines; k++)
                    {
                        
                        gr.DrawString(Convert.ToString(counter), myFont, Brushes.Black, x, y);
                        gr.DrawEllipse(myPen, PlayerX, PlayerY, 25, 25);
                        x += xSpace;
                        
                        counter++;

                    }
                    y += ySpace;
                    x = 0;
                }
            }
            COUNT++;
        }


        public string SNAKE()
        {
            string snake = "Snake";
            return snake;
        }

        public int mnum = 0;
        public bool UDKeyPressed = false;
        public int move = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Up) { move = -25; UDKeyPressed = true; }
            if (e.KeyCode == Keys.Down) { move = 25; UDKeyPressed = true; }
            if (e.KeyCode == Keys.Left) { move = -25; UDKeyPressed = false; }
            if (e.KeyCode == Keys.Right) { move = 25; UDKeyPressed = false; }


        }

        private void Movement()
        {
            while (UDKeyPressed == true)
            {
                PlayerY += move;
                createGrid(0);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

           

        }
    }
}
