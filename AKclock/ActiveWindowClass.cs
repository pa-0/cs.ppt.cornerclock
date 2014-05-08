using System;
using System.Text;
using System.Runtime.InteropServices;

namespace AKclock {
    class ActiveWindowClass {
        private string desktopClass1 = "Progman";   // standard desktop class name
        private string desktopClass2 = "WorkerW";   // class name after wallpaper change
        private bool isDesktopActive;

        public ActiveWindowClass() {
        }

        // return whether the desktop is the active window
        public bool IsDesktopActive {
            get { return isDesktopActive; }
        }

        // get active window class name
        // modified from http://www.csharphelp.com/2006/08/get-current-window-handle-and-caption-with-windows-api-in-c/
        // and http://msdn.microsoft.com/en-us/library/windows/desktop/ms633582(v=vs.85).aspx
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetClassName(int hWnd, StringBuilder lpClassName, int nMaxCount);

        public void GetActiveWindow() {
            const int maxChars = 256;
            int handle = 0;
            StringBuilder className = new StringBuilder(maxChars);

            handle = GetForegroundWindow();

            if (GetClassName(handle, className, maxChars) > 0) {
                string cName = className.ToString();
                if (cName == desktopClass1 || cName == desktopClass2) {
                    isDesktopActive = true;
                } else {
                    isDesktopActive = false;
                }
            }
        }
    }
}
