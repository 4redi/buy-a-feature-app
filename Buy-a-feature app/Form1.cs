using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System;
using System.Data.Common;

namespace Buy_a_feature_app
{

    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private string openedFilePath;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Buy-a-feature app";
            User.Text = "Add Columns";
            CellValidatingEvent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.RowTemplate.Height = 80;


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
                    MessageBox.Show("The file requires Title and Description!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = null;
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                    openedFilePath = filePath;
                }
            }
        }

        private void Load_File_Click(object sender, EventArgs e)
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

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            iDelete();
        }


        private void Exit_Click(object sender, EventArgs e)
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

        private void Insert_Users_Click(object sender, EventArgs e)
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
            //dataGridView1.Columns["Title"].ReadOnly = true;
            //dataGridView1.Columns["Description"].ReadOnly = true;
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

                        if (value < 0 && value > 100 && sum + value > 100)
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

        private void SaveChanges(string filePath)
        {
            try
            {
                if (dataTable == null || string.IsNullOrEmpty(filePath))
                    return;

                dataGridView1.EndEdit();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));

                foreach (DataRow row in dataTable.Rows)
                {
                    string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                    sb.AppendLine(string.Join(",", fields));
                }
                File.WriteAllText(filePath, sb.ToString());

                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int userColumnStartIndex = 4;

            if (e.ColumnIndex >= userColumnStartIndex)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    double sum = 0;
                    int count = 0;

                    for (int i = userColumnStartIndex; i < dataGridView1.Columns.Count; i++)
                    {
                        double value;
                        if (double.TryParse(row.Cells[i].Value?.ToString(), out value))
                        {
                            sum += value;
                            count++;
                        }
                    }
                    double average = Math.Round(sum / count);
                    row.Cells["AVERAGE"].Value = average;
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveChanges(openedFilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void deletecol_Click(object sender, EventArgs e)
        {
            string colname= deletecolumn.Text;
            try
            {
                if (colname==""){
                    MessageBox.Show("Dont click unless you want to remove a column", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    dataGridView1.Columns.Remove(colname);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
