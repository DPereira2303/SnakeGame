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

            createGrid(num);


        }

        public int num = 45;



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
            for (int j = 0; j < lines; j++)
            {
                for (int k = 0; k < lines; k++)
                {
                    if (counter == num)
                    {
                        gr.DrawString(S, myFont, Brushes.Black, x, y);
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


        public string SNAKE()
        {
            string snake = "Snake";
            return snake;
        }

        public int mnum = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Up) { mnum = -10; }
            if (e.KeyCode == Keys.Left) { mnum = -1; }
            if (e.KeyCode == Keys.Down) { mnum = 10; }
            if (e.KeyCode == Keys.Right) { mnum = 1; }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            while (true)
            {
                System.Threading.Thread.Sleep(200);
                num += mnum;
                createGrid(num);
                if (num < 0) { num -= mnum; createGrid(num); break; }
            }

        }
    }
}
