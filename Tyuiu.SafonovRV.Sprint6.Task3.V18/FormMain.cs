using Tyuiu.SafonovRV.Sprint6.Task3.V18.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix = { { -19, -19, 1, 18, 7 },
                             { 5, 3, -4, -6, -12 },
                             { -15, 6, 2, 2, -14, },
                             { -9, -10, 15, -5, -6 },
                             { -13, -15, -9, 7, 1 } };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewTask_SRV.ColumnCount = columns;
            dataGridViewTask_SRV.RowCount = rows;

            dataGridViewResult_SRV.ColumnCount = columns;
            dataGridViewResult_SRV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTask_SRV.Columns[i].Width = 25;
                dataGridViewResult_SRV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask_SRV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 3 выполнил студент группы ј—ќи”б-24-1 —афонов …–услан ¬асильевич", "—ообщение", MessageBoxButtons.OK);
        }

        private void buttonExecute_SMA_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(matrix);

            int rows = result_matrix.GetUpperBound(0) + 1;
            int columns = result_matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SRV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
