using Tyuiu.SafonovRV.Sprint6.Task6.V24.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonInfo_SRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }

        private void ButtonDone_SRV_Click(object sender, EventArgs e)
        {
            TextBoxOutput_SRV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void ButtonOpen_SRV_Click(object sender, EventArgs e)
        {
            OpenFileDialog_SRV.ShowDialog();
            openFilePath = OpenFileDialog_SRV.FileName;
            TextBoxInput_SRV.Text = File.ReadAllText(openFilePath);
            GroupBoxOutput_SRV.Text = GroupBoxOutput_SRV.Text + " " + OpenFileDialog_SRV.FileName;
            ButtonDone_SRV.Enabled = true;

        }
    }
}
