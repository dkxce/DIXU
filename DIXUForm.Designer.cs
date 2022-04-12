namespace DIXU
{
    partial class DIXUForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIXUForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.decToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ааToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sharedKey = new System.Windows.Forms.ComboBox();
            this.baseKey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.onFly = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 31);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "W-1251",
            "UTF-8",
            "oem866"});
            this.comboBox1.Location = new System.Drawing.Point(667, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Кодировка текстовых файлов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Утилита для быстрой шифровки и дешифровки текста и документов";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 465);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Текст";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 140);
            this.panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(748, 140);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 244);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(748, 22);
            this.panel5.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.ContextMenuStrip = this.contextMenuStrip2;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(94, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 22);
            this.button10.TabIndex = 14;
            this.button10.Text = "Меню...";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffToolStripMenuItem,
            this.tfToolStripMenuItem1,
            this.clrToolStripMenuItem,
            this.toolStripMenuItem2,
            this.decToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cpToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(236, 126);
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.ffToolStripMenuItem.Text = "Загрузить из файла ...";
            this.ffToolStripMenuItem.Click += new System.EventHandler(this.ffToolStripMenuItem_Click);
            // 
            // tfToolStripMenuItem1
            // 
            this.tfToolStripMenuItem1.Name = "tfToolStripMenuItem1";
            this.tfToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.tfToolStripMenuItem1.Text = "Сохранить в файл ...";
            this.tfToolStripMenuItem1.Click += new System.EventHandler(this.tfToolStripMenuItem1_Click);
            // 
            // clrToolStripMenuItem
            // 
            this.clrToolStripMenuItem.Name = "clrToolStripMenuItem";
            this.clrToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.clrToolStripMenuItem.Text = "Очистить";
            this.clrToolStripMenuItem.Click += new System.EventHandler(this.clrToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 6);
            // 
            // decToolStripMenuItem
            // 
            this.decToolStripMenuItem.Name = "decToolStripMenuItem";
            this.decToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.decToolStripMenuItem.Text = "Раскодировать";
            this.decToolStripMenuItem.Click += new System.EventHandler(this.decToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(232, 6);
            // 
            // cpToolStripMenuItem
            // 
            this.cpToolStripMenuItem.Name = "cpToolStripMenuItem";
            this.cpToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cpToolStripMenuItem.Text = "Скопировать в буфер обмена";
            this.cpToolStripMenuItem.Click += new System.EventHandler(this.cpToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Раскодировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(195, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Зашифрованный текст:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 266);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(748, 170);
            this.panel6.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(748, 170);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.onFly);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 24);
            this.panel3.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(94, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 22);
            this.button9.TabIndex = 13;
            this.button9.Text = "Меню...";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ааToolStripMenuItem,
            this.tfToolStripMenuItem,
            this.clToolStripMenuItem,
            this.toolStripMenuItem1,
            this.codeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 98);
            // 
            // ааToolStripMenuItem
            // 
            this.ааToolStripMenuItem.Name = "ааToolStripMenuItem";
            this.ааToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ааToolStripMenuItem.Text = "Загрузить из файла ...";
            this.ааToolStripMenuItem.Click += new System.EventHandler(this.ааToolStripMenuItem_Click);
            // 
            // tfToolStripMenuItem
            // 
            this.tfToolStripMenuItem.Name = "tfToolStripMenuItem";
            this.tfToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tfToolStripMenuItem.Text = "Сохранить в файл ...";
            this.tfToolStripMenuItem.Click += new System.EventHandler(this.tfToolStripMenuItem_Click);
            // 
            // clToolStripMenuItem
            // 
            this.clToolStripMenuItem.Name = "clToolStripMenuItem";
            this.clToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clToolStripMenuItem.Text = "Очистить";
            this.clToolStripMenuItem.Click += new System.EventHandler(this.clToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.codeToolStripMenuItem.Text = "Закодировать";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(195, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Текст для кодирования:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.sharedKey);
            this.panel2.Controls.Add(this.baseKey);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 77);
            this.panel2.TabIndex = 0;
            // 
            // sharedKey
            // 
            this.sharedKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sharedKey.FormattingEnabled = true;
            this.sharedKey.Location = new System.Drawing.Point(212, 29);
            this.sharedKey.Name = "sharedKey";
            this.sharedKey.Size = new System.Drawing.Size(458, 21);
            this.sharedKey.TabIndex = 4;
            this.sharedKey.SelectedIndexChanged += new System.EventHandler(this.sharedKey_SelectedIndexChanged);
            // 
            // baseKey
            // 
            this.baseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseKey.FormattingEnabled = true;
            this.baseKey.Location = new System.Drawing.Point(212, 7);
            this.baseKey.Name = "baseKey";
            this.baseKey.Size = new System.Drawing.Size(458, 21);
            this.baseKey.TabIndex = 3;
            this.baseKey.SelectedIndexChanged += new System.EventHandler(this.baseKey_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(621, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Передайте номер базового ключа, текст и передаваемый произвольный ключ собеседник" +
                "у для раскодирования текста";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Передаваемый произвольный ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стандартный базовый ключ:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Файлы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // onFly
            // 
            this.onFly.AutoSize = true;
            this.onFly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onFly.Location = new System.Drawing.Point(609, 3);
            this.onFly.Name = "onFly";
            this.onFly.Size = new System.Drawing.Size(122, 17);
            this.onFly.TabIndex = 14;
            this.onFly.Text = "кодировать на лету";
            this.onFly.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(671, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Новый \r\nключ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 22);
            this.button4.TabIndex = 12;
            this.button4.Text = "Закодировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(6, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 22);
            this.button5.TabIndex = 13;
            this.button5.Text = "Раскодировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(107, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 22);
            this.button6.TabIndex = 14;
            this.button6.Text = "Закодировать и сохранить в новый...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(107, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(225, 22);
            this.button7.TabIndex = 15;
            this.button7.Text = "Раскодировать и сохранить в новый...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "О программе";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Автор: milokz@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "https://github.com/dkxce/DIXU";
            // 
            // DIXUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DIXUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIXU - Кодирование и декодирование v0.1";
            this.Load += new System.EventHandler(this.DIXUForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DIXUForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox sharedKey;
        private System.Windows.Forms.ComboBox baseKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ааToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clrToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cpToolStripMenuItem;
        private System.Windows.Forms.CheckBox onFly;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

