using ScottPlot;
using System.Windows.Forms.VisualStyles;
using Tyuiu.UlukhanovDV.Sprint6.Task2.V19.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task2.V19
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
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                dataGridView.Rows.Clear();
                dataGridView.Rows.Clear();
                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    dataGridView.Rows.Add(Convert.ToString(currentX), Convert.ToString(valueArray[i]));
                }

                PlotGraph(startStep, stopStep, valueArray);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неверные данные: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = System.Drawing.Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = System.Drawing.Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = System.Drawing.Color.Blue;
        }

        private void formsPlotFunction_Load(object sender, EventArgs e)
        {

        }
    }
}
