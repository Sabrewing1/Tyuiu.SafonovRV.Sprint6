using Tyuiu.SafonovRV.Sprint6.Task1.V4.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtwosrv_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelpClick_srv_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-24-1 Сафонов Руслан Васильевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonStrt_click_srv_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {

                int startStep = Convert.ToInt32(textBoxone_srv.Text);
                int stopStep = Convert.ToInt32(textBoxtwosrv.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |    f(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

