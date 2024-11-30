using Tyuiu.SafonovRV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ������-24-1 ������� ������ ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonDoneClick(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxEnter_X.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
