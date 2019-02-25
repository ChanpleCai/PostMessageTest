using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PostMessageTest
{
    internal static class Program
    {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// Return Type: BOOL->int
        /// hWnd: HWND->HWND__*
        /// Msg: UINT->unsigned int
        /// wParam: WPARAM->UINT_PTR->unsigned int
        /// lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessageW(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);
    }
}