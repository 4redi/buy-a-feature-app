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
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID_Generated = new DataGridViewTextBoxColumn();
            average = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            button5 = new Button();
            textBox1 = new TextBox();
            User = new Label();
            Sum = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(8, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 522);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(20, 291);
            button7.Name = "button7";
            button7.Size = new Size(202, 57);
            button7.TabIndex = 7;
            button7.Text = "Insert";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(20, 211);
            button4.Name = "button4";
            button4.Size = new Size(202, 57);
            button4.TabIndex = 4;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(152, 485);
            button3.Name = "button3";
            button3.Size = new Size(83, 34);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(20, 131);
            button2.Name = "button2";
            button2.Size = new Size(202, 57);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(28, 12);
            button1.Name = "button1";
            button1.Size = new Size(193, 51);
            button1.TabIndex = 1;
            button1.Text = "Load CSV";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Generated, average, Sum });
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
            average.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(User);
            panel2.Location = new Point(272, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 99);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(630, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.Location = new Point(520, 41);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 2;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
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
            // Sum
            // 
            Sum.HeaderText = "Sum";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            Sum.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(995, 606);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox textBox1;
        private Label User;
        private Button button7;
        private DataGridViewTextBoxColumn ID_Generated;
        private DataGridViewTextBoxColumn average;
        private Label label1;
        private Button button5;
        private DataGridViewTextBoxColumn Sum;
    }
}