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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Закодировать файлы";
                ofd.Filter = "Все типы (*.*)|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int fok = 0;
                    int fbad = 0;
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, ofd.FileNames.Length);
                        try
                        {
                            dkxce.Crypt.DIXUFile.EncyptFile(ofd.FileNames[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                            fok++;
                        }
                        catch (Exception ex)
                        {
                            fbad++;
                        };
                    };
                    stLabel.Text = String.Format("Зашифровано {0} файлов, неудачно {1}", fok, fbad);
                };
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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Разкодировать файлы";
                ofd.Filter = "Все типы (*.*)|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int fok = 0;
                    int fbad = 0;
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, ofd.FileNames.Length);
                        try
                        {
                            dkxce.Crypt.DIXUFile.DecyptFile(ofd.FileNames[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                            fok++;
                        }
                        catch (Exception ex)
                        {
                            fbad++;
                        };
                    };
                    stLabel.Text = String.Format("Расшифровано {0} файлов, неудачно {1}", fok, fbad);
                };
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

        private void button8_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            string path = XMLState.GetCurrentDir();
            if (InputBox.QueryDirectoryBox("Закодировать папку", "Выберите папку:", ref path) != DialogResult.OK) return;
            if (!Directory.Exists(path)) return;

            string[] files = Directory.GetFiles(path, "*.*");
            if ((files == null) || (files.Length == 0)) return;
            int fok = 0;
            int fbad = 0;
            for (int i = 0; i < files.Length; i++)
            {
                stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, files.Length);
                try
                {
                    dkxce.Crypt.DIXUFile.EncyptFile(files[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    fok++;
                }
                catch (Exception ex)
                {
                    fbad++;
                };
            };
            stLabel.Text = String.Format("Зашифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            string path = XMLState.GetCurrentDir();
            if (InputBox.QueryDirectoryBox("Разкодировать папку", "Выберите папку:", ref path) != DialogResult.OK) return;
            if (!Directory.Exists(path)) return;

            string[] files = Directory.GetFiles(path, "*.*");
            if ((files == null) || (files.Length == 0)) return;
            int fok = 0;
            int fbad = 0;
            for (int i = 0; i < files.Length; i++)
            {
                stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, files.Length);
                try
                {
                    dkxce.Crypt.DIXUFile.DecyptFile(files[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    fok++;
                }
                catch (Exception ex)
                {
                    fbad++;
                };
            };
            stLabel.Text = String.Format("Расшифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            string path = XMLState.GetCurrentDir();
            if (InputBox.QueryDirectoryBox("Закодировать папку с подкаталогами", "Выберите папку:", ref path) != DialogResult.OK) return;
            if (!Directory.Exists(path)) return;

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            if ((files == null) || (files.Length == 0)) return;
            int fok = 0;
            int fbad = 0;
            for (int i = 0; i < files.Length; i++)
            {
                stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, files.Length);
                try
                {
                    dkxce.Crypt.DIXUFile.EncyptFile(files[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    fok++;
                }
                catch (Exception ex)
                {
                    fbad++;
                };
            };
            stLabel.Text = String.Format("Зашифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            string path = XMLState.GetCurrentDir();
            if (InputBox.QueryDirectoryBox("Разкодировать папку с подкаталогами", "Выберите папку:", ref path) != DialogResult.OK) return;
            if (!Directory.Exists(path)) return;

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            if ((files == null) || (files.Length == 0)) return;
            int fok = 0;
            int fbad = 0;
            for (int i = 0; i < files.Length; i++)
            {
                stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, files.Length);
                try
                {
                    dkxce.Crypt.DIXUFile.DecyptFile(files[i], System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    fok++;
                }
                catch (Exception ex)
                {
                    fbad++;
                };
            };
            stLabel.Text = String.Format("Расшифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Открыть файл для кодирования";
                ofd.Multiselect = true;
                ofd.Filter = "Все типы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Сохранить закодированный файл";
                    sfd.Filter = "DIXU Archive (*.dxa)|*.dxa";
                    sfd.DefaultExt = ".dxa";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        EncodeZip(ofd.FileNames, sfd.FileName, null);
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

        private void DecodeZip(string file, string path)
        {
            FileStream sf = new FileStream(file, FileMode.Open, FileAccess.Read);
            int fok = 0; int fbad = 0;
            if (sf.Length > 16)
            {
                // HEADER
                byte[] data = new byte[16];
                sf.Read(data, 0, data.Length);
                if (System.Text.Encoding.ASCII.GetString(data) == "DIXU_ARCHIVE\0\0\r\n")
                {
                    // FILES COUNT
                    data = new byte[8];
                    sf.Read(data, 0, 8);
                    long fCount = BitConverter.ToInt64(data, 0);
                    if (fCount > 0)
                    {
                        // FILES
                        for (int i = 0; i < fCount; i++)
                        {
                            data = new byte[8];
                            sf.Read(data, 0, data.Length);
                            long fLen = BitConverter.ToInt64(data, 0);
                            data = new byte[fLen];
                            sf.Read(data, 0, data.Length);
                            data = dkxce.Crypt.DIXU.Decrypt(data, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                            string fName = System.Text.Encoding.UTF8.GetString(data);
                            data = new byte[8];
                            sf.Read(data, 0, data.Length);
                            long fSize = BitConverter.ToInt64(data, 0);
                            // FILE
                            string nfn = Path.Combine(path, fName);
                            Directory.CreateDirectory(Path.GetDirectoryName(nfn));
                            FileStream fs = new FileStream(nfn, FileMode.Create, FileAccess.Write);
                            data = new byte[65536];
                            int read = 0; int readed = 0;
                            while ((readed < fSize) && ((read = sf.Read(data, 0, (int)Math.Min(data.Length, fSize - readed))) > 0))
                            {
                                readed += read;
                                byte[] newbuff = dkxce.Crypt.DIXU.Decrypt(data, 0, read, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                                fs.Write(newbuff, 0, newbuff.Length);
                            };
                            fs.Close();
                            fok++;
                        };
                    };
                };
            };
            sf.Close();
            stLabel.Text = String.Format("Расшифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void EncodeZip(string[] files, string dest, string relPath)
        {
            FileStream df = new FileStream(dest, FileMode.Create, FileAccess.Write);
            // HEADER
            byte[] data = System.Text.Encoding.ASCII.GetBytes("DIXU_ARCHIVE\0\0\r\n");
            df.Write(data, 0, data.Length);
            // FILES COUNT
            data = BitConverter.GetBytes((long)files.Length);
            df.Write(data, 0, data.Length);
            // FILES
            int fok = 0;
            int fbad = 0;
            for (int i = 0; i < files.Length; i++)
            {
                stLabel.Text = String.Format("Обработка файла: {0}/{1}", i + 1, files.Length);
                // File Name
                string fn = String.IsNullOrEmpty(relPath) ? Path.GetFileName(files[i]) : GetRelativePath(files[i], relPath);
                byte[] fnd = System.Text.Encoding.UTF8.GetBytes(fn);
                fnd = dkxce.Crypt.DIXU.Encrypt(fnd, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                data = BitConverter.GetBytes((long)fnd.Length);
                df.Write(data, 0, data.Length);
                df.Write(fnd, 0, fnd.Length);
                // File Data
                FileStream fs = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                data = BitConverter.GetBytes((long)fs.Length);
                df.Write(data, 0, data.Length);
                //
                data = new byte[65536];
                int read = 0;
                while ((read = fs.Read(data, 0, data.Length)) > 0)
                {
                    byte[] newbuff = dkxce.Crypt.DIXU.Encrypt(data, 0, read, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                    df.Write(newbuff, 0, newbuff.Length);
                };
                fs.Close();
                fok++;
            };
            df.Close();
            stLabel.Text = String.Format("Зашифровано {0} файлов, неудачно {1}", fok, fbad);
        }

        private void InfoZip(string file)
        {
            FileStream sf = new FileStream(file, FileMode.Open, FileAccess.Read);
            string text = "";
            if (sf.Length > 16)
            {
                // HEADER
                byte[] data = new byte[16];
                sf.Read(data, 0, data.Length);
                if (System.Text.Encoding.ASCII.GetString(data) == "DIXU_ARCHIVE\0\0\r\n")
                {
                    // FILES COUNT
                    data = new byte[8];
                    sf.Read(data, 0, 8);
                    long fCount = BitConverter.ToInt64(data, 0);
                    if (fCount > 0)
                    {
                        // FILES
                        for (int i = 0; i < fCount; i++)
                        {
                            data = new byte[8];
                            sf.Read(data, 0, data.Length);
                            long fLen = BitConverter.ToInt64(data, 0);
                            data = new byte[fLen];
                            sf.Read(data, 0, data.Length);
                            data = dkxce.Crypt.DIXU.Decrypt(data, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[baseKey.SelectedIndex]), sharedKey.Text.Trim());
                            string fName = System.Text.Encoding.UTF8.GetString(data);
                            data = new byte[8];
                            sf.Read(data, 0, data.Length);
                            long fSize = BitConverter.ToInt64(data, 0);
                            sf.Position += fSize;
                            text += String.Format("{0}\t\t\t\t - {1}\r\n", fName, BytesToString(fSize));
                        };
                    };
                };
            };
            sf.Close();
            MessageBox.Show(text, Path.GetFileName(file), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Открыть файл для разкодирования";
                ofd.Filter = "DIXU Archive (*.dxa)|*.dxa";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = XMLState.GetCurrentDir();
                    if (InputBox.QueryDirectoryBox("Путь для разкодированных файлов", "Выберите папку:", ref path) != DialogResult.OK) return;
                    if (!Directory.Exists(path)) return;
                    DecodeZip(ofd.FileName, path);
                };
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button17_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            string path = XMLState.GetCurrentDir();
            if (InputBox.QueryDirectoryBox("Закодировать папку в архив", "Выберите папку:", ref path) != DialogResult.OK) return;
            if (!Directory.Exists(path)) return;

            string saveTo = null;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить закодированный файл";
            sfd.Filter = "DIXU Archive (*.dxa)|*.dxa";
            sfd.DefaultExt = ".dxa";
            if (sfd.ShowDialog() == DialogResult.OK) saveTo = sfd.FileName;
            sfd.Dispose();

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            if ((files == null) || (files.Length == 0)) return;

            EncodeZip(files, saveTo, path);
        }

        private string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                folder += Path.DirectorySeparatorChar;
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            stLabel.Text = "";

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Открыть файл для информации";
                ofd.Filter = "DIXU Archive (*.dxa)|*.dxa";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    InfoZip(ofd.FileName);
                };
                ofd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private static string BytesToString(long length)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (length == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(length);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(length) * num).ToString() + " " + suf[place];
        }
    }
}