namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                GameGrid.Rows.Add();
            }
        }

        private void GameGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}