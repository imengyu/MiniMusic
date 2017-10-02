using Microsoft.Win32;
using MusicPlayer.MyLayeredSkin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] agrs)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!File.Exists(Application.StartupPath + "\\bass.dll"))
                {
                    MessageBox.Show("无法加载迷你音乐的某个组件，程序可能已经损坏，请重新安装迷你音乐。", "这里出现了一点错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process[] p = Process.GetProcessesByName("MusicPlayer");

                    if (agrs.Length > 0)
                    {
                        string agrsc = "";
                        for (int i = 0; i < agrs.Length; i++)
                        {
                            agrsc = agrsc + " " + agrs[i];
                        }
                        if (Path.GetExtension(agrsc.ToLower()) == ".mp3" || Path.GetExtension(agrsc.ToLower()) == ".wav" || agrsc.ToLower().Contains(".mp3") || agrsc.ToLower().Contains(".mpa") || agrsc.ToLower().Contains(".mpc") || agrsc.ToLower().Contains(".wav") || agrsc.ToLower().Contains(".wmv") || agrsc.ToLower().Contains(".wv") || Path.GetExtension(agrsc.ToLower()) == ".m4a" || agrsc.ToLower().Contains(".wma") || agrsc.ToLower().Contains(".midi") || agrsc.ToLower().Contains(".mid") || Path.GetExtension(agrsc.ToLower()) == ".mid" || Path.GetExtension(agrsc.ToLower()) == ".midi" || Path.GetExtension(agrsc.ToLower()) == ".ogg")
                        {
                            if (p.Length > 1)
                            {
                                WinMessageUntil.SendMessageToProcess("MusicPlayer", "music#" + agrsc.Remove(0, 1));
                            }
                            else
                            {
                                Application.Run(new FormMain(agrsc.Remove(0, 1)));
                            }
                        }
                        else if (agrs[0] == "-test" || agrs[0] == "/test")
                        {
                            string agrs80968 = agrs[10];
                        }
                        else if (agrs[0] == "-test2" || agrs[0] == "/test2")
                        {

                        }
                        else if (agrs[0] == "-?" || agrs[0] == "/?")
                        {
                            MessageBox.Show("命令行参数：\nMusicPlayer.exe <文件名>    打开支持的文件，\nMusicPlayer.exe /test1    测试1，\nMusicPlayer.exe /mvplayer    mv播放器测试，\nMusicPlayer.exe /errorrestart    错误报告测试，\nMusicPlayer.exe /assion    修改打开方式.", "信息：");
                        }
                        else if (agrs[0] == "-test1" || agrs[0] == "/test1")
                        {

                        }
                        else if (agrs[0] == "-mvplayer" || agrs[0] == "/mvplayer")
                        {

                        }
                        else if (agrs[0] == "-errorrestart" || agrs[0] == "/errorrestart")
                        {
                            Application.Run(new FormErrorReport(agrs[1]));
                        }
                        else if (agrs[0] == "-assion" || agrs[0] == "/assion")
                        {
                            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                            if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                            {
                                try
                                {
                                    RegistryKey key = Registry.ClassesRoot;

                                    #region 修改1
                                    string[] openf = new string[12];
                                    openf[0] = "mp3";
                                    openf[1] = "wav";
                                    openf[2] = "lrc";
                                    openf[3] = "wma";
                                    openf[4] = "m4a";
                                    openf[5] = "flac";
                                    openf[6] = "ogg";
                                    openf[8] = "ra";
                                    openf[9] = "cd";
                                    openf[10] = "mid";
                                    openf[11] = "midi";
                                    for (int i = 0; i < openf.Length; i++)
                                    {
                                        if (openf[i] != "" && openf[i] != null)
                                        {
                                            RegistryKey m1 = key.OpenSubKey("MusicPlayer." + openf[i]);
                                            if (m1 == null)
                                            {
                                                m1 = key.CreateSubKey("MusicPlayer." + openf[i]);
                                                RegistryKey m1icon = m1.CreateSubKey("DefaultIcon");
                                                if (openf[i] == "mp3")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,7");
                                                if (openf[i] == "m4a")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,10");
                                                else if (openf[i] == "wav")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,8");
                                                else if (openf[i] == "lrc")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,6");
                                                else if (openf[i] == "wma")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,9");
                                                else if (openf[i] == "wma")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,9");
                                                else if (openf[i] == "cd")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,14");
                                                else if (openf[i] == "ra")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,13");
                                                else if (openf[i] == "flac")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,5");
                                                else if (openf[i] == "mid")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,11");
                                                else if (openf[i] == "midi")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,11");
                                                else if (openf[i] == "ogg")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,12");

                                                RegistryKey shell = m1.CreateSubKey("Shell");
                                                RegistryKey open = shell.CreateSubKey("Open");
                                                if (openf[i] == "mp3" || openf[i] == "wma" || openf[i] == "m4a" || openf[i] == "wav")
                                                    open.SetValue("", "播放音乐(&O)");
                                                else
                                                    open.SetValue("", "打开(&O)");
                                                RegistryKey command = open.CreateSubKey("command");
                                                command.SetValue("", Application.StartupPath + "\\MusicPlayer.exe \"%1\"");
                                            }
                                            else
                                            {
                                                key.DeleteSubKeyTree("MusicPlayer." + openf[i]);
                                                m1 = key.CreateSubKey("MusicPlayer." + openf[i]);
                                                RegistryKey m1icon = m1.CreateSubKey("DefaultIcon");
                                                if (openf[i] == "mp3")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,7");
                                                if (openf[i] == "m4a")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,10");
                                                else if (openf[i] == "wav")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,8");
                                                else if (openf[i] == "lrc")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,6");
                                                else if (openf[i] == "wma")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,9");
                                                else if (openf[i] == "wma")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,9");
                                                else if (openf[i] == "cd")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,14");
                                                else if (openf[i] == "ra")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,13");
                                                else if (openf[i] == "flac")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,5");
                                                else if (openf[i] == "mid")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,11");
                                                else if (openf[i] == "midi")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,11");
                                                else if (openf[i] == "ogg")
                                                    m1icon.SetValue("", Application.StartupPath + "\\MusicPlayer.Utils.dll,12");

                                                RegistryKey shell = m1.CreateSubKey("Shell");
                                                RegistryKey open = shell.CreateSubKey("Open");
                                                if (openf[i] == "mp3" || openf[i] == "wma" || openf[i] == "m4a" || openf[i] == "wav")
                                                    open.SetValue("", "播放音乐(&O)");
                                                else
                                                    open.SetValue("", "打开(&O)");
                                                RegistryKey command = open.CreateSubKey("command");
                                                command.SetValue("", Application.StartupPath + "\\MusicPlayer.exe \"%1\"");
                                            }

                                            RegistryKey m2 = key.OpenSubKey("." + openf[i], true);
                                            if (m2 != null)
                                            {
                                                key.DeleteSubKeyTree("." + openf[i]);
                                            }
                                            RegistryKey m4 = Registry.CurrentUser;
                                            RegistryKey m3 = m4.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\." + openf[i], true);
                                            if (m3 != null)
                                            {
                                                try
                                                {
                                                    m4.DeleteSubKeyTree(@"Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\." + openf[i]);
                                                }
                                                catch
                                                {

                                                }
                                            }
                                            m2 = key.CreateSubKey("." + openf[i]);
                                            RegistryKey m21 = m2.OpenSubKey("OpenWithProgIds", true);
                                            if (m21 == null)
                                            {
                                                m21 = m2.CreateSubKey("OpenWithProgIds");
                                                m21.SetValue("MusicPlayer." + openf[i], 0, RegistryValueKind.DWord);
                                            }
                                            else
                                            {
                                                m21.SetValue("MusicPlayer." + openf[i], 0, RegistryValueKind.DWord);
                                            }
                                            m2.SetValue("", "MusicPlayer." + openf[i]);


                                        }
                                        else
                                        {

                                        }
                                    }

                                    #endregion

                                    SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero);
                                }
                                catch (Exception ee)
                                {
                                    MessageBox.Show(ee.ToString(), "这里有个错误:" + ee.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("修改默认打开方式需要修改注册表，这必须要系统管理员权限，请选择“重试”并在稍后弹出的对话框中选择“是”继续。如果不想修改，请选择“取消”。", "这里有个错误:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                                {
                                    //创建启动对象 
                                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                    //设置运行文件 
                                    startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
                                    startInfo.Arguments = String.Join(" ", agrs);
                                    startInfo.Verb = "runas";
                                    System.Diagnostics.Process.Start(startInfo);
                                    System.Windows.Forms.Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            if (File.Exists(agrsc))
                            {
                                MessageBox.Show("不支持的文件格式:\n" + Path.GetExtension(agrsc), "错误:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("命令行参数错误，未知的参数:\n" + agrsc + "\n输入 \"-?\" 了解更多。", "错误:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        if (p.Length > 1)
                        {
                            WinMessageUntil.SendMessageToProcess("MusicPlayer", "show");
                        }
                        else
                        {
                            Application.Run(new FormMain());
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("迷你音乐遇到错误需要关闭，给您带来不便深表歉意。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteLog(ee.Message, DateTime.Now.ToString(), ee.ToString());
                string time = Application.StartupPath + @"\MusicPlayerError_log_" + DateTime.Now.Minute + ".log";
                FileStream fs = new FileStream(time, FileMode.Create);
                fs.Write(System.Text.Encoding.Default.GetBytes("迷你音乐错误记录："), 0, System.Text.Encoding.Default.GetBytes("迷你音乐错误记录：").Length);
                fs.Close();
                StreamWriter sw = new StreamWriter(time, true, System.Text.Encoding.Default);
                sw.WriteLine();
                sw.WriteLine("错误时间：");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine(ee.ToString());
                sw.Close();
                Process.Start(Application.StartupPath + @"\MusicPlayer.exe", "-errorrestart " + System.IO.Path.GetFileName(time));
            }
        }
        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
        public static void WriteLog(string errormsg, string errortime, string errordata)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\MusicPlayerError.log", true);
            sw.WriteLine("********************************************************");
            sw.WriteLine("ErrorTime:" + errortime + "|" + errormsg);
            sw.WriteLine(errordata);
            sw.Close();
        }
    }
}
