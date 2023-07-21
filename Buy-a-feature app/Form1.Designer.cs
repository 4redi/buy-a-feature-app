namespace Buy_a_feature_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Insert = new Button();
            Delete = new Button();
            Exit = new Button();
            Save = new Button();
            Load_File = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            User = new Label();
            dataGridView1 = new DataGridView();
            ID_Generated = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(Insert);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Save);
            panel1.Location = new Point(8, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 522);
            panel1.TabIndex = 0;
            // 
            // Insert
            // 
            Insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Insert.Location = new Point(20, 291);
            Insert.Name = "Insert";
            Insert.Size = new Size(202, 57);
            Insert.TabIndex = 7;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Users_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.Location = new Point(20, 211);
            Delete.Name = "Delete";
            Delete.Size = new Size(202, 57);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Button_Delete_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Location = new Point(152, 485);
            Exit.Name = "Exit";
            Exit.Size = new Size(83, 34);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Save.Location = new Point(20, 131);
            Save.Name = "Save";
            Save.Size = new Size(202, 57);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Load_File
            // 
            Load_File.BackColor = Color.DarkSalmon;
            Load_File.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Load_File.ForeColor = SystemColors.ActiveCaptionText;
            Load_File.Location = new Point(28, 12);
            Load_File.Name = "Load_File";
            Load_File.Size = new Size(193, 51);
            Load_File.TabIndex = 1;
            Load_File.Text = "Load CSV";
            Load_File.UseVisualStyleBackColor = false;
            Load_File.Click += Load_File_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(User);
            panel2.Location = new Point(272, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 99);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(172, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 34);
            textBox1.TabIndex = 1;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            User.ForeColor = SystemColors.ActiveCaptionText;
            User.Location = new Point(29, 44);
            User.Name = "User";
            User.Size = new Size(137, 28);
            User.TabIndex = 0;
            User.Text = "Add Columns";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Generated, average });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(272, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(712, 476);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellEndEdit += dataGridView1_CellContentClick;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // ID_Generated
            // 
            ID_Generated.HeaderText = "ID_Generated";
            ID_Generated.MinimumWidth = 6;
            ID_Generated.Name = "ID_Generated";
            ID_Generated.ReadOnly = true;
            ID_Generated.Width = 125;
            // 
            // average
            // 
            average.HeaderText = "AVERAGE";
            average.MinimumWidth = 6;
            average.Name = "average";
            average.ReadOnly = true;
            average.SortMode = DataGridViewColumnSortMode.NotSortable;
            average.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(995, 606);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(Load_File);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Delete;
        private Button Exit;
        private Button Save;
        private Button Load_File;
        private Panel panel2;
        private TextBox textBox1;
        private Label User;
        private Button Insert;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Generated;
        private DataGridViewTextBoxColumn average;
    }
}