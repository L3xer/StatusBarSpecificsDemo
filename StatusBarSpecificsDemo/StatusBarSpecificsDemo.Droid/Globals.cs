using Android.Views;

namespace StatusBarSpecificsDemo.Droid
{
    public class Globals
    {
        private static Window _window;
        public static Window Window
        {
            get { return _window; }
            set { _window = value; }
        }
    }
}