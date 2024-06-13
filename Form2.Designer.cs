namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 41);
            label1.Name = "label1";
            label1.Size = new Size(203, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите количество вершин графа:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(394, 37);
            button1.Name = "button1";
            button1.Size = new Size(60, 23);
            button1.TabIndex = 2;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 80);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите количество вершин:";
            label2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(125, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(297, 190);
            dataGridView1.TabIndex = 4;
            dataGridView1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(296, 572);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 5;
            button2.Text = "Ввести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 572);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 6;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 329);
            label3.Name = "label3";
            label3.Size = new Size(199, 15);
            label3.TabIndex = 7;
            label3.Text = "Введите начальную вершину пути:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 366);
            label4.Name = "label4";
            label4.Size = new Size(193, 15);
            label4.TabIndex = 9;
            label4.Text = "Введите конечную вершину пути:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 363);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 406);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 11;
            label5.Text = "Введите первую вершину:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(296, 403);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 447);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 13;
            label6.Text = "Введите вторую вершину:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(296, 447);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 487);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 15;
            label7.Text = "Введите первое ребро:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(284, 487);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(55, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(360, 487);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(55, 23);
            textBox7.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 530);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 18;
            label8.Text = "Введите второе ребро:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(284, 527);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(55, 23);
            textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(360, 527);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(55, 23);
            textBox9.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 607);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}