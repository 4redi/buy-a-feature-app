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
            deletecol = new Button();
            deletecolumn = new TextBox();
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
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(Insert);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Save);
            panel1.Location = new Point(8, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 1087);
            panel1.TabIndex = 0;
            // 
            // Insert
            // 
            Insert.BackColor = SystemColors.HighlightText;
            Insert.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Insert.ForeColor = SystemColors.ControlDarkDark;
            Insert.Location = new Point(32, 684);
            Insert.Name = "Insert";
            Insert.Size = new Size(345, 97);
            Insert.TabIndex = 7;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = false;
            Insert.Click += Insert_Users_Click;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.HighlightText;
            Delete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ControlDarkDark;
            Delete.Location = new Point(42, 439);
            Delete.Name = "Delete";
            Delete.Size = new Size(335, 100);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Button_Delete_Click;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.Menu;
            Exit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = SystemColors.InactiveCaptionText;
            Exit.Location = new Point(113, 1006);
            Exit.Name = "Exit";
            Exit.Size = new Size(274, 67);
            Exit.TabIndex = 3;
            Exit.Text = "Exit?";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.HighlightText;
            Save.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ControlDarkDark;
            Save.Location = new Point(42, 175);
            Save.Name = "Save";
            Save.Size = new Size(325, 96);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Load_File
            // 
            Load_File.BackColor = SystemColors.ControlLightLight;
            Load_File.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Load_File.ForeColor = SystemColors.ActiveCaptionText;
            Load_File.Location = new Point(28, 12);
            Load_File.Name = "Load_File";
            Load_File.Size = new Size(357, 88);
            Load_File.TabIndex = 1;
            Load_File.Text = "Load CSV";
            Load_File.UseVisualStyleBackColor = false;
            Load_File.Click += Load_File_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(deletecol);
            panel2.Controls.Add(deletecolumn);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(User);
            panel2.Location = new Point(426, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1701, 99);
            panel2.TabIndex = 3;
            // 
            // deletecol
            // 
            deletecol.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletecol.ForeColor = SystemColors.ControlDark;
            deletecol.Location = new Point(1459, 17);
            deletecol.Name = "deletecol";
            deletecol.Size = new Size(239, 67);
            deletecol.TabIndex = 8;
            deletecol.Text = "Delete";
            deletecol.UseVisualStyleBackColor = true;
            deletecol.Click += deletecol_Click;
            // 
            // deletecolumn
            // 
            deletecolumn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletecolumn.Location = new Point(792, 15);
            deletecolumn.Name = "deletecolumn";
            deletecolumn.Size = new Size(661, 71);
            deletecolumn.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(377, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 71);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            User.ForeColor = SystemColors.Control;
            User.Location = new Point(30, 24);
            User.Name = "User";
            User.Size = new Size(341, 58);
            User.TabIndex = 0;
            User.Text = "Add Columns";
            User.Click += User_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.GhostWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Generated, average });
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(428, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1699, 1087);
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
            ID_Generated.SortMode = DataGridViewColumnSortMode.Programmatic;
            ID_Generated.Width = 300;
            // 
            // average
            // 
            average.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            average.HeaderText = "AVERAGE";
            average.MinimumWidth = 6;
            average.Name = "average";
            average.ReadOnly = true;
            average.Resizable = DataGridViewTriState.True;
            average.SortMode = DataGridViewColumnSortMode.Programmatic;
            average.Width = 263;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(24F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(2139, 1215);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(Load_File);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buy a feature app";
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
        private Button deletecol;
        private TextBox deletecolumn;
    }
}