using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer
{
    public static class WinMessageUntil
    {
        private struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
        //使用COPYDATA进行跨进程通信
        public const int WM_COPYDATA = 0x004A;
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
        int hWnd, // handle to destination window
        int Msg, // message
        int wParam, // first message parameter
        ref COPYDATASTRUCT lParam // second message parameter
        );
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="windowReceiveTitle">接收方窗体标题名称</param>
        /// <param name="strData">要发送的数据</param>
        public static void SendMessageToWindow(string windowReceiveTitle, string strData)
        {
            int winHandler = FindWindow(null, windowReceiveTitle);
            if (winHandler != 0)
            {
                byte[] sarr = System.Text.Encoding.Default.GetBytes(strData);
                int len = sarr.Length + 1;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = strData;
                cds.cbData = len;
                SendMessage(winHandler, WM_COPYDATA, 0, ref cds);
            }
        }
        /// <summary>
        /// 发送信息至一个程序
        /// </summary>
        /// <param name="processName">进程名称</param>
        /// <param name="strData">自定义信息</param>
        public static void SendMessageToProcess(string processName, string strData)
        {
            if (processName == "MusicPlayer")
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath + @"\data\MusicPlayer.dat");
                    int id = int.Parse(sr.ReadLine());
                    byte[] sarr = System.Text.Encoding.Default.GetBytes(strData);
                    int len = sarr.Length + 1;
                    COPYDATASTRUCT cds;
                    cds.dwData = (IntPtr)100;
                    cds.lpData = strData;
                    cds.cbData = len;
                    SendMessage(id, WM_COPYDATA, 0, ref cds);
                }
                catch { MessageBox.Show("这里出了点小错误。"); }
            }
            else
            {
                Process[] p = Process.GetProcessesByName(processName);
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].Id != Process.GetCurrentProcess().Id)
                    {
                        string windowReceiveTitle = p[i].MainWindowTitle;
                        //System.Windows.Forms.MessageBox.Show(p[i].MainWindowTitle);
                        int winHandler = FindWindow(null, windowReceiveTitle);
                        if (winHandler != 0)
                        {
                            //System.Windows.Forms.MessageBox.Show("窗体:"+winHandler.ToString());
                            byte[] sarr = System.Text.Encoding.Default.GetBytes(strData);
                            int len = sarr.Length + 1;
                            COPYDATASTRUCT cds;
                            cds.dwData = (IntPtr)100;
                            cds.lpData = strData;
                            cds.cbData = len;
                            SendMessage(winHandler, WM_COPYDATA, 0, ref cds);
                        }
                    }
                }
            }
        }
        public static void SendMessageToMusicPlayer(string strData)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath + @"\data\MusicPlayer.dat");
                int id = int.Parse(sr.ReadLine());
                byte[] sarr = System.Text.Encoding.Default.GetBytes(strData);
                int len = sarr.Length + 1;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = strData;
                cds.cbData = len;
                SendMessage(id, WM_COPYDATA, 0, ref cds);
            }
            catch { MessageBox.Show("这里出了点小错误。"); }
        }

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <example>
        /// 在窗体中覆盖接收消息函数
        /// protected override void DefWndProc(ref System.Windows.Forms.Message m)
        /// {
        ///   switch(m.Msg)
        ///   {
        ///     case WinMessageHelper.WM_COPYDATA:
        ///       string str = WinMessageHelper.Receive(ref m);
        ///       break;
        ///     default:
        ///       base.DefWndProc(ref m);
        ///       break;
        /// 
        ///   }
        /// }
        public static string Receive(ref System.Windows.Forms.Message m)
        {
            COPYDATASTRUCT cds = new COPYDATASTRUCT();
            Type cdsType = cds.GetType();
            cds = (COPYDATASTRUCT)m.GetLParam(cdsType);
            return cds.lpData;
        }
    }
}
