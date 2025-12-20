using Tyuiu.UlukhanovDV.Sprint6.Task4.V27.Lib;
using System.Windows.Forms;

namespace Tyuiu.UlukhanovDV.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] value = new double[len];

                value = ds.GetMassFunction(startValue, stopValue);

                textBoxRes.Clear();
                for (int i = 0; i < len; i++)
                {
                    textBoxRes.AppendText($"{value[i]}" + Environment.NewLine);
                }
                PlotGraph(startValue, stopValue, value);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void PlotGraph(int startValue, int stopValue, double[] yValues)
        {
            var plt = formsPlotFunction.Plot;
            plt.Clear();

            int len = yValues.Length;

            double[] xValues = new double[len];
            for (int i = 0; i < len; i++)
            {
                xValues[i] = startValue + i;
            }

            var scatter = plt.Add.Scatter(xValues, yValues);
            scatter.LineWidth = 2;
            scatter.MarkerSize = 5;

            plt.Title("График функции f(x)");
            plt.XLabel("X");
            plt.YLabel("F(x)");

            formsPlotFunction.Refresh();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Улуханов Д.В. Группа: СМАРТб-25-1");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetTempFileName();
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
