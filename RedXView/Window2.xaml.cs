using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;


namespace RedXView
{
    /// <summary>
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        public Window2()
        {
            InitializeComponent();
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {

        }


        public void setText(string text)
        {
            textBlock.Text = text;
            textBlock_Copy.Text = text;
            textBlock_Copy1.Text = text;
            textBlock_Copy2.Text = text;           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            var hwnd = new WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
