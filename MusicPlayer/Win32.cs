using System;
using System.Runtime.InteropServices;

namespace MusicPlayer
{
    public class DllInvoke
    {

        #region Win API
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
        #endregion

        private IntPtr hLib;
        public DllInvoke(String DLLPath)
        {
            if (System.IO.File.Exists(DLLPath))
                hLib = LoadLibrary(DLLPath);
            else
                throw new Exception("Dll not found!");
        }
        ~DllInvoke()
        {
            FreeLibrary(hLib);
        }
        //将要执行的函数转换为委托
        public Delegate Invoke(string APIName, Type t)
        {
            //System.Windows.Forms.MessageBox.Show(hLib.ToString());
            IntPtr api = GetProcAddress(hLib, APIName);
            if (api != null && api != IntPtr.Zero)
                return (Delegate)Marshal.GetDelegateForFunctionPointer(api, t);
            else
            {
                throw new Exception("Not found address!\nMethod name: " + APIName);
            }
        }

    }
    public static class Win32
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLongA(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowLong(IntPtr hWnd, int nlndex);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(HandleRef hDC, int x, int y, int nWidth, int nHeight, HandleRef hSrcDC, int xSrc, int ySrc, int dwRop);
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);
        [DllImport("User32.dll")]
        public static extern uint RegisterWindowMessageA(string lpStr);
        [DllImport("bassmidi.dll")]
        public static extern int BASS_MIDI_StreamCreateFile(int basstruefalse, string filename, int a, int b, int basstype, int c);
        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("zlib.dll")]
        public static extern int compress(byte[] dest, ref int destLen, byte[] src, int srcLen);
        [DllImport("zlib.dll")]
        public static extern int uncompress(byte[] dest, ref int destLen, byte[] src, int srcLen);
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// 执行动画
        /// </summary>
        /// <param name="whnd">控件句柄</param>
        /// <param name="dwtime">动画时间</param>
        /// <param name="dwflag">动画组合名称</param>
        /// <returns>bool值，动画是否成功</returns>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

        /// <summary>
        /// 从左到右显示
        /// </summary>
        public const Int32 AW_HOR_POSITIVE = 0x00000001;
        /// <summary>
        /// 从右到左显示
        /// </summary>
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;
        /// <summary>
        /// 从上到下显示
        /// </summary>
        public const Int32 AW_VER_POSITIVE = 0x00000004;
        /// <summary>
        /// 从下到上显示
        /// </summary>
        public const Int32 AW_VER_NEGATIVE = 0x00000008;
        /// <summary>
        /// 若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        /// </summary>
        public const Int32 AW_CENTER = 0x00000010;
        /// <summary>
        /// 隐藏窗口，缺省则显示窗口
        /// </summary>
        public const Int32 AW_HIDE = 0x00010000;
        /// <summary>
        /// 激活窗口。在使用了AW_HIDE标志后不能使用这个标志
        /// </summary>
        public const Int32 AW_ACTIVATE = 0x00020000;
        /// <summary>
        /// 使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        /// </summary>
        public const Int32 AW_SLIDE = 0x00040000;
        /// <summary>
        /// 透明度从高到低
        /// </summary>
        public const Int32 AW_BLEND = 0x00080000;
        public static ushort LOWORD(uint value)
        {
            return (ushort)(value & 0xFFFF);
        }
        public static ushort HIWORD(uint value)
        {
            return (ushort)(value >> 16);
        }
        public static byte LOWBYTE(ushort value)
        {
            return (byte)(value & 0xFF);
        }
        public static byte HIGHBYTE(ushort value)
        {
            return (byte)(value >> 8);

        }
    }
}
