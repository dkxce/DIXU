using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DIXU
{
    public partial class DIXUForm : Form
    {
        private System.Text.Encoding textEnc = System.Text.Encoding.GetEncoding(1251);

        public DIXUForm()
        {
            InitializeComponent();
        }

        private void DIXUForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Std_Key.KEYS.Length; i++)
                baseKey.Items.Add("СТАНДАРТНЫЙ КЛЮЧ №" + (i + 1).ToString());
            baseKey.SelectedIndex = 0;

            if (String.IsNullOrEmpty(sharedKey.Text))
                sharedKey.Text = dkxce.Crypt.DIXU.GenerateKeyText(64);

            comboBox1.SelectedIndex = 0;

            try
            {
                XMLState xs = new XMLState();                
                try
                {
                    string mdp = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString();
                    xs = XMLState.Load(mdp + @"\DIXU_laststate.xml");
                }
                catch { };
                try { xs = XMLState.Load(XMLState.GetCurrentDir() + @"\DIXU_laststate.xml"); } catch { };
                comboBox1.SelectedIndex = xs.textEnc;
                baseKey.SelectedIndex = xs.baseKey;
                onFly.Checked = xs.onFly;                
                if (!String.IsNullOrEmpty(xs.lastText)) textBox1.Text = xs.lastText.Replace("\n","\r\n");
                if (!String.IsNullOrEmpty(xs.lastCode)) textBox2.Text = xs.lastCode;
                if (xs.keyHistory.Count > 0)
                {
                    for (int i = 0; i < xs.keyHistory.Count; i++)
                        sharedKey.Items.Add(xs.keyHistory[i].Trim());
                    sharedKey.SelectedIndex = xs.keyHistory.Count - 1;
                };
            }
            catch { };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                textBox1.Text = dkxce.Crypt.DIXU.DecryptText(textBox2.Text, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                textBox1.SelectAll();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
            };
        }

    

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: textEnc = System.Text.Encoding.GetEncoding(1251); break;
                case 1: textEnc = System.Text.Encoding.UTF8; break;
                case 2: textEnc = System.Text.Encoding.GetEncoding(866); break;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                textBox2.Text = dkxce.Crypt.DIXU.EncryptText(textBox1.Text, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                textBox2.SelectAll();
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.ToString();
            };
        }

      
        private void DIXUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            XMLState xs = new XMLState();
            try { xs = XMLState.Load(XMLState.GetCurrentDir() + @"\DIXU_laststate.xml"); } catch { };
            try
            {
                if (xs.keyHistory == null) xs.keyHistory = new List<string>();
                int ind = xs.keyHistory.IndexOf(sharedKey.Text.Trim());
                if(ind >= 0) xs.keyHistory.RemoveAt(ind);
                xs.keyHistory.Add(sharedKey.Text.Trim());
                while (xs.keyHistory.Count > 20) xs.keyHistory.RemoveAt(0);

                xs.textEnc = (byte)comboBox1.SelectedIndex;
                xs.baseKey = (byte)baseKey.SelectedIndex;
                xs.lastText = textBox1.Text;
                xs.lastCode = textBox2.Text;
                xs.onFly = onFly.Checked;

                try { XMLState.Save(XMLState.GetCurrentDir() + @"\DIXU_laststate.xml", xs); } catch (Exception ex) { };
                try
                {
                    string mdp = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString();
                    XMLState.Save(mdp + @"\DIXU_laststate.xml", xs);
                }
                catch (Exception ex)
                {

                };
            }
            catch { };
        }

        private void ааToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, textEnc);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            };
            ofd.Dispose();
            if (onFly.Checked) button1_Click(sender, e);
        }

        private void clToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (onFly.Checked) textBox2.Clear();
        }

        private void tfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.DefaultExt = ".txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, textEnc);
                sr.Write(textBox1.Text);
                sr.Close();
                fs.Close();
            };
            ofd.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button9, new Point(0, button1.Height));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(button10, new Point(0, button2.Height));
        }

        private void ffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, textEnc);
                textBox2.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            };
            ofd.Dispose();
        }

        private void tfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.DefaultExt = ".txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs, textEnc);
                sr.Write(textBox2.Text);
                sr.Close();
                fs.Close();
            };
            ofd.Dispose();
        }

        private void decToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void clrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            codeToolStripMenuItem.Enabled = button1.Enabled = textBox1.Text.Length > 0;
            if (onFly.Checked) button1_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            decToolStripMenuItem.Enabled = button2.Enabled = textBox2.Text.Length > 0;
        }

        private void cpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text, TextDataFormat.UnicodeText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sharedKey.Text = dkxce.Crypt.DIXU.GenerateKeyText(64);
            if (onFly.Checked) button1_Click(sender, e);
        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void baseKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onFly.Checked) button1_Click(sender, e);
        }

        private void sharedKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onFly.Checked) button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Title = "Закодировать файл";
                ofd.Filter = "Все типы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    dkxce.Crypt.DIXUFile.EncyptFile(ofd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Title = "Разкодировать файл";
                ofd.Filter = "Все типы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    dkxce.Crypt.DIXUFile.DecyptFile(ofd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Открыть файл для кодирования";
                ofd.Filter = "Все типы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Сохранить закодированный файл";
                    string ext = Path.GetExtension(ofd.FileName);
                    sfd.Filter = "Как исходный файл (*" + ext + ")|*" + ext + "|Все типы (*.*)|*.*";
                    sfd.DefaultExt = ext;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        dkxce.Crypt.DIXUFile.EncyptFile(ofd.FileName, sfd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    };
                    sfd.Dispose();
                };
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Открыть файл для декодирования";
                ofd.Filter = "Все типы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Сохранить разкодированный файл";
                    string ext = Path.GetExtension(ofd.FileName);
                    sfd.Filter = "Как исходный файл (*" + ext + ")|*" + ext + "|Все типы (*.*)|*.*";
                    sfd.DefaultExt = ext;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        dkxce.Crypt.DIXUFile.DecyptFile(ofd.FileName, sfd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    };
                    sfd.Dispose();
                };
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}