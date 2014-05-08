using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AKclock {
    class ActiveWindowSize {
        private bool isFullScreen;    // detect if another app is fullscreen

        public ActiveWindowSize() {
        }

        // returns whether the focused app is fullscreen
        public bool IsFullScreen {
            set { isFullScreen = value; }
            get { return isFullScreen; }
        }

        // detect if other app is fullscreen
        // taken from http://stackoverflow.com/a/3744720/2585881
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(HandleRef hWnd, [In, Out] ref RECT rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static bool IsForegroundFullScreen() {
            return IsForegroundFullScreen(null);
        }

        public static bool IsForegroundFullScreen(Screen screen) {
            if (screen == null) {
                screen = Screen.PrimaryScreen;
            }
            RECT rect = new RECT();
            GetWindowRect(new HandleRef(null, GetForegroundWindow()), ref rect);
            return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top).Contains(screen.Bounds);
        }
    }
}
