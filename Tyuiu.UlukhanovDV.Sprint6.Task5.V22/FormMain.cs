using Tyuiu.UlukhanovDV.Sprint6.Task5.V22.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\djabr\source\repos\Tyuiu.UlukhanovDV.Sprint6\Tyuiu.UlukhanovDV.Sprint6.Task5.V22.Test\bin\Debug\net8.0\InPutDataFileTask5V22.txt";
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Улуханов Д.В. Группа: СМАРТб-25-1");
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.Rows.Clear();
            dataGridViewNums.Columns.Clear();

            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].HeaderText = "X";
            dataGridViewNums.Columns[1].HeaderText = "Y";

            double[] numsMass = ds.LoadFromDataFile(path);
            int n = numsMass.Length;

            double[] positions = new double[n];
            for (int i = 0; i < n; i++)
            {
                positions[i] = i;
                dataGridViewNums.Rows.Add(i.ToString(), numsMass[i].ToString("F2"));
            }

            var plt = formsPlotBars.Plot;
            plt.Clear();

            var bars = plt.Add.Bars(numsMass);
            

            plt.Title("Диаграмма");
            plt.XLabel("Ось X");
            plt.YLabel("Ось Y");
            

            
            formsPlotBars.Refresh();
        }

    }
}
