using Tyuiu.SafonovRV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task7.V17
{



    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_SRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        string path; 
        static int rows;
        static int columns;


        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonDone_SRV_Click(object sender, EventArgs e)
        {

            int[,] arrayValues = LoadFromFileData(path);

            dataGridViewOut_SRV.ColumnCount = columns;
            dataGridViewOut_SRV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOut_SRV.Columns[i].Width = 35;
            }
  

            arrayValues = ds.GetMatrix(path);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SRV.Rows[r].Cells[c].Value = arrayValues[r, c];

                }
            }
            
        }

        private void buttonInfo_SRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы АСОиУб-24-1 Сафонов Руслан Васильевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void buttonSave_SRV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SRV.FileName = "OutPutFileTask7V17.csv";
            saveFileDialogMatrix_SRV.InitialDirectory = Path.Combine(new string[] { Path.GetTempPath() });
            saveFileDialogMatrix_SRV.ShowDialog();

            string outputpath = saveFileDialogMatrix_SRV.FileName;

            FileInfo fileInfo = new FileInfo(outputpath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(outputpath);
            }

            int rows = dataGridViewOut_SRV.RowCount;
            int columns = dataGridViewOut_SRV.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_SRV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_SRV.Rows[i].Cells[j].Value + "";
                    }
                }
            }
            File.AppendAllText(outputpath, str + Environment.NewLine);
            str = "";
        }
        private void File_Load_IME(object sender, EventArgs e)
        {
            dataGridViewIn_SRV.ColumnCount = 50;
            dataGridViewOut_SRV.ColumnCount = 50;

            dataGridViewOut_SRV.RowCount = 50;
            dataGridViewIn_SRV.RowCount = 50;
            groupBoxInPut_SRV.Width = this.Width / 2;
            groupBoxOutPut_SRV.Width = this.Width / 2;
        }



        private void buttonOpenFile_SRV_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonOpenFile_SRV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonDone_SRV_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonDone_SRV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonSave_SRV_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonSave_SRV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonInfo_SRV_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonInfo_SRV_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonOpenFile_SRV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SRV.InitialDirectory = Path.Combine(new string[] { Path.GetTempPath() });
            openFileDialogTask_SRV.ShowDialog();
            path = openFileDialogTask_SRV.FileName;

            int[,] arrayValues = LoadFromFileData(path);

            dataGridViewIn_SRV.ColumnCount = columns;
            dataGridViewIn_SRV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_SRV.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SRV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            
        }
    }
    }


