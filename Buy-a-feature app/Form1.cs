using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Buy_a_feature_app
{

    public partial class Form1 : Form
    {
        private DataTable dataTable;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Buy-a-feature app";
            User.Text = "Add Columns";
            CellValidatingEvent();

        }
        private void ReadCSVFile(string filePath)
        {

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] headers = parser.ReadFields();

                dataTable = new DataTable();

                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }

                bool hasTitle = dataTable.Columns.Contains("Title");
                bool hasDescription = dataTable.Columns.Contains("Description");

                if (!hasDescription || !hasTitle)
                {
                    MessageBox.Show("The file requires Title and Description!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    dataGridView1.DataSource = null;
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ReadCSVFile(ofd.FileName);
                bool hasTitle = dataTable.Columns.Contains("Title");
                bool hasDescription = dataTable.Columns.Contains("Description");
                if (!hasDescription || !hasTitle)
                {
                    MessageBox.Show("The file requires Title and Description!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do you really want to exit?", "Exit"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string newHeader = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newHeader))
            {
                if (!newHeader.Contains(" "))
                {
                    DataColumn newColumn = new DataColumn(newHeader);
                    newColumn.DataType = typeof(int);
                    dataTable.Columns.Add(newColumn);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Header name cannot contain whitespace.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid header name.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns["Title"].ReadOnly = true;
            dataGridView1.Columns["Description"].ReadOnly = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerName = dataGridView1.Columns[e.ColumnIndex].Name;
            Type dataType = dataGridView1.Columns[e.ColumnIndex].ValueType;
            if (dataType == typeof(int))
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    int value;
                    if (int.TryParse(e.FormattedValue.ToString(), out value))
                    {
                        int sum = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Index != e.RowIndex && row.Cells[e.ColumnIndex].Value != null)
                            {
                                int cellValue;
                                if (int.TryParse(row.Cells[e.ColumnIndex].Value.ToString(), out cellValue))
                                {
                                    sum += cellValue;
                                }
                            }
                        }

                        if (value < 0 || value > 100 || sum + value > 100)
                        {
                            e.Cancel = true;
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Invalid integer value or sum exceeds 100!";
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Invalid input!";
                    }
                }
            }
        }
        private void CellValidatingEvent()
        {
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }


    }
}