using Tyuiu.UlukhanovDV.Sprint6.Task7.V14.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task7.V14
{
    public partial class ForMain : Form
    {
        public ForMain()
        {
            InitializeComponent();
            openFileDialogTask_UDV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_UDV.Filter = "Значения, разделённые запятыми(*.csv)| *.csv | Все файлы(*.*) | *.* ";
        }
        DataService ds = new DataService();
        static int rows;
        static int cols;
        static string OpenFilePath;
        private void buttonSave_UDV_Click(object sender, EventArgs e)
        {
            saveFileDialog_UDV.FileName = "OutputFileTask7.csv";
            saveFileDialog_UDV.ShowDialog();
            string path = saveFileDialog_UDV.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_UDV.RowCount;
            int columns = dataGridViewOutput_UDV.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_UDV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_UDV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_UDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_UDV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_UDV.ShowDialog();
            OpenFilePath = openFileDialogTask_UDV.FileName;
            string fileData = File.ReadAllText(OpenFilePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(OpenFilePath);
            dataGridViewInput_UDV.ColumnCount = cols;
            dataGridViewInput_UDV.RowCount = rows;
            dataGridViewOutput_UDV.ColumnCount = cols;
            dataGridViewOutput_UDV.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewInput_UDV.Columns[i].Width = 25;
                dataGridViewOutput_UDV.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInput_UDV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_UDV.Enabled = true;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
        }

        private void buttonDone_UDV_Click(object sender, EventArgs e)
        {
            string fileData = File.ReadAllText(OpenFilePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOutput_UDV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_UDV.Enabled = true;
        }
    }
}
