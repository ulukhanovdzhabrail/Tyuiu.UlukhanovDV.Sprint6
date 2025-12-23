using Tyuiu.UlukhanovDV.Sprint6.Task6.V19.Lib;
namespace Tyuiu.UlukhanovDV.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxTextInFile.Text = File.ReadAllText(openFilePath);
            textBoxTextInFile.Text = textBoxTextInFile.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string text = textBoxTextInFile.Text;
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void openFileDialogTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
