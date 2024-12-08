using Tyuiu.SafonovRV.Sprint6.Task4.V29.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {

            DataService ds = new DataService();
            void button1_Click(object sender, EventArgs e)
            {

            }

            void buttonDone_Click(object sender, EventArgs e)
            {
                try
                {
                    int BoxStart = Convert.ToInt32(textBoxStart.Text);
                    int BoxEnd = Convert.ToInt32(textBoxStop.Text);
                    int len = ds.GetMassFunction(BoxStart, BoxEnd).Length;
                    double[] arr = new double[len];
                    double[] valarr = ds.GetMassFunction(BoxStart, BoxEnd);

                    this.chartFunc.ChartAreas[0].AxisX.Title = "��� �";
                    this.chartFunc.ChartAreas[0].AxisY.Title = "��� Y";
                    textBoxRes.Text = "";
                    chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                    for (int i = 0; i < len; i++)
                    {
                        this.chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                        textBoxRes.AppendText(valarr[i] + Environment.NewLine);
                        BoxStart++;
                    }
                }
                catch
                {
                    MessageBox.Show("Fail");
                }
            }

            void buttonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                    File.WriteAllText(path, textBoxRes.Text);
                    DialogResult dialogResult = MessageBox.Show("����" + path + "���������� �������\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    dialogResult = DialogResult.Yes;
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                }
                catch
                {
                    MessageBox.Show("Fail");
                }
            }

        }
    }
}

            
            

            
        
    

