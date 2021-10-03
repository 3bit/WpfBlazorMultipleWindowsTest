using WpfBlazorMultipleWindowsTest.Blazor;

namespace WpfBlazorMultipleWindowsTest
{
    internal class WindowManager : IWindowManager
    {
        
        public void OpenAnotherWindow()
        {
            var window = new Window1();
            window.Show();
        }
    }
}
