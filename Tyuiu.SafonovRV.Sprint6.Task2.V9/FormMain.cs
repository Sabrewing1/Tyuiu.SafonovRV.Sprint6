using Tyuiu.SafonovRV.Sprint6.Task2.V9.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private object chart_srv;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ ������-24-1 ������� ������ ����������");
        }
        private void buttonStrt_click_srv_Click(object sender, EventArgs e)
        {

            
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
