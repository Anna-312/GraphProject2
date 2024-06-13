namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            вводДанныхToolStripMenuItem = new ToolStripMenuItem();
            сКлавиатурыToolStripMenuItem = new ToolStripMenuItem();
            изФайлаToolStripMenuItem = new ToolStripMenuItem();
            работаToolStripMenuItem = new ToolStripMenuItem();
            запуститьВторичныйПотокToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { вводДанныхToolStripMenuItem, работаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // вводДанныхToolStripMenuItem
            // 
            вводДанныхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сКлавиатурыToolStripMenuItem, изФайлаToolStripMenuItem });
            вводДанныхToolStripMenuItem.Name = "вводДанныхToolStripMenuItem";
            вводДанныхToolStripMenuItem.Size = new Size(89, 20);
            вводДанныхToolStripMenuItem.Text = "Ввод данных";
            // 
            // сКлавиатурыToolStripMenuItem
            // 
            сКлавиатурыToolStripMenuItem.Name = "сКлавиатурыToolStripMenuItem";
            сКлавиатурыToolStripMenuItem.Size = new Size(150, 22);
            сКлавиатурыToolStripMenuItem.Text = "С клавиатуры";
            сКлавиатурыToolStripMenuItem.Click += сКлавиатурыToolStripMenuItem_Click;
            // 
            // изФайлаToolStripMenuItem
            // 
            изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            изФайлаToolStripMenuItem.Size = new Size(150, 22);
            изФайлаToolStripMenuItem.Text = "Из файла";
            изФайлаToolStripMenuItem.Click += изФайлаToolStripMenuItem_Click;
            // 
            // работаToolStripMenuItem
            // 
            работаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { запуститьВторичныйПотокToolStripMenuItem });
            работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            работаToolStripMenuItem.Size = new Size(57, 20);
            работаToolStripMenuItem.Text = "Работа";
            // 
            // запуститьВторичныйПотокToolStripMenuItem
            // 
            запуститьВторичныйПотокToolStripMenuItem.Name = "запуститьВторичныйПотокToolStripMenuItem";
            запуститьВторичныйПотокToolStripMenuItem.Size = new Size(229, 22);
            запуститьВторичныйПотокToolStripMenuItem.Text = "Запустить вторичный поток";
            запуститьВторичныйПотокToolStripMenuItem.Click += запуститьВторичныйПотокToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 49);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Найденный путь:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(614, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 598);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вводДанныхToolStripMenuItem;
        private ToolStripMenuItem сКлавиатурыToolStripMenuItem;
        private ToolStripMenuItem изФайлаToolStripMenuItem;
        private ToolStripMenuItem работаToolStripMenuItem;
        private ToolStripMenuItem запуститьВторичныйПотокToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox textBox1;
    }
}