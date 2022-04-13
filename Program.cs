using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIXU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            RegWin32.Register();

            if ((args != null) && (args.Length > 1))
            {
                string fn = args[1];
                if (System.IO.File.Exists(fn))
                {
                    XMLState xs = null;
                    try {
                        string mdp = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString();
                        xs = XMLState.Load(mdp + @"\DIXU_laststate.xml"); } catch { };
                    try { xs = XMLState.Load(XMLState.GetCurrentDir() + @"\DIXU_laststate.xml"); } catch { };
                    if (xs != null)
                    {
                        if (args[0] == "-encrypt")
                        {
                            dkxce.Crypt.DIXUFile.EncyptFile(fn, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            MessageBox.Show("Файл зашифрован!", "DIXU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        };
                        if (args[0] == "-escrypt")
                        {
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.Title = "Сохранить закодированный файл";
                            string ext = System.IO.Path.GetExtension(fn);
                            sfd.Filter = "Как исходный файл (*" + ext + ")|*" + ext + "|Все типы (*.*)|*.*";
                            sfd.DefaultExt = ext;
                            if (sfd.ShowDialog() == DialogResult.OK)
                                dkxce.Crypt.DIXUFile.EncyptFile(fn, sfd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            sfd.Dispose();                            
                            return;
                        };
                        if (args[0] == "-decrypt")
                        {
                            dkxce.Crypt.DIXUFile.DecyptFile(fn, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            MessageBox.Show("Файл расшифрован!", "DIXU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        };
                        if (args[0] == "-dscrypt")
                        {
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.Title = "Сохранить разкодированный файл";
                            string ext = System.IO.Path.GetExtension(fn);
                            sfd.Filter = "Как исходный файл (*" + ext + ")|*" + ext + "|Все типы (*.*)|*.*";
                            sfd.DefaultExt = ext;
                            if (sfd.ShowDialog() == DialogResult.OK)
                                dkxce.Crypt.DIXUFile.DecyptFile(fn, sfd.FileName, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            sfd.Dispose();
                            return;
                        };
                        if (args[0] == "-excrypt")
                        {

                            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(fn), System.IO.Path.GetFileNameWithoutExtension(fn) + @"\");
                            if (InputBox.QueryDirectoryBox("Разкодировать в папку", "Выберите папку:", ref path) != DialogResult.OK) return;
                            System.IO.Directory.CreateDirectory(path);

                            DecodeZip(fn, path, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            MessageBox.Show("Файл распакован!", "DIXU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        };
                        if (args[0] == "-ezcrypt")
                        {

                            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(fn), System.IO.Path.GetFileNameWithoutExtension(fn) + @"\");
                            System.IO.Directory.CreateDirectory(path);

                            DecodeZip(fn, path, System.Text.Encoding.ASCII.GetBytes(Std_Key.KEYS[xs.baseKey]), xs.keyHistory[xs.keyHistory.Count - 1].Trim());
                            MessageBox.Show("Файл распакован!", "DIXU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        };
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, не найдены ключи шифрования!", "DIXU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    };
                };
                return;
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DIXUForm());
        }

        private static void DecodeZip(string file, string path, byte[] baseKey, string sharedKey)
        {
            System.IO.FileStream sf = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
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
                            data = dkxce.Crypt.DIXU.Decrypt(data, baseKey, sharedKey);
                            string fName = System.Text.Encoding.UTF8.GetString(data);
                            data = new byte[8];
                            sf.Read(data, 0, data.Length);
                            long fSize = BitConverter.ToInt64(data, 0);
                            // FILE
                            string nfn = System.IO.Path.Combine(path, fName);
                            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(nfn));
                            System.IO.FileStream fs = new System.IO.FileStream(nfn, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                            data = new byte[65536];
                            int read = 0; int readed = 0;
                            while ((readed < fSize) && ((read = sf.Read(data, 0, (int)Math.Min(data.Length, fSize - readed))) > 0))
                            {
                                readed += read;
                                byte[] newbuff = dkxce.Crypt.DIXU.Decrypt(data, 0, read, baseKey, sharedKey);
                                fs.Write(newbuff, 0, newbuff.Length);
                            };
                            fs.Close();
                            fok++;
                        };
                    };
                };
            };
            sf.Close();
        }
    }
}