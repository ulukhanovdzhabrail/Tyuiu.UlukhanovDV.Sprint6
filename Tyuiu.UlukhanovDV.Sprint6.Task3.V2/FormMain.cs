using Tyuiu.UlukhanovDV.Sprint6.Task3.V2.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5] { { -12, -4, -20, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };
        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;
            dataGridViewCondition.ColumnCount = colums;
            dataGridViewCondition.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewCondition.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewCondition.Rows[i].Cells[j].Value = Convert.ToString(mas2[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Âûïîëíèë: Óëóõàíîâ Ä.Â. Ãðóïïà: ÑÌÀÐÒá-25-1");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                
                int[,] resultArray = ds.Calculate(mas2);
                int rows = resultArray.GetUpperBound(0) + 1;
                int colums = resultArray.Length / rows;
                dataGridViewResult.ColumnCount = colums;
                dataGridViewResult.RowCount = rows;
                for (int i = 0; i < colums; i++)
                {
                    dataGridViewResult.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(resultArray[i, j]);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Îøèáêà: {ex.Message}", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
