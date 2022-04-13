using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace DIXU
{
    public class RegWin32
    {
        public static void Register()
        {
            try
            {
                RegistryKey regmenu = null;
                RegistryKey regcmd = null;
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@"*\shell\Encrypt with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", "Encrypt with DIXU (Закодировать DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@"*\shell\Encrypt with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -encrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@"*\shell\EnSave with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", "Encrypt && Save... with DIXU (Закодировать в новый файл DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@"*\shell\EnSave with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -escrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@"*\shell\Decrypt with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", @"Decrypt with DIXU (Разкодировать DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@"*\shell\Decrypt with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -decrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@"*\shell\DeSave with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", @"Decrypt && Save... with DIXU (Разкодировать в новый файл DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@"*\shell\DeSave with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -dscrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@".dxa\shell\Extract... with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", @"Extract... with DIXU (Распаковать DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@".dxa\shell\Extract... with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -excrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(@".dxa\shell\Extract with DIXU");
                    if (regmenu != null)
                    {
                        regmenu.SetValue("", @"Extract with DIXU (Распаковать DIXU)");
                        regmenu.SetValue("Icon", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                    };
                    regcmd = Registry.ClassesRoot.CreateSubKey(@".dxa\shell\Extract with DIXU\command");
                    if (regcmd != null)
                        regcmd.SetValue("", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " -ezcrypt \"%1\"");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (regmenu != null) regmenu.Close();
                    if (regcmd != null) regcmd.Close();
                };
            }
            catch { };
        }
    }
}
