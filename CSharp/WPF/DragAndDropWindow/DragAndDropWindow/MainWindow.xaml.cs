using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace DragAndDropWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DragAndDrop dragAndDropWindow;
        public MainWindow()
        {
            InitializeComponent();
            dragAndDropWindow = new DragAndDrop(this);
        }

        private new void PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Main Window: PreviewMouseLeftButtonDown");
            this.OnMouseLeftButtonDown(sender, e);
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Main Window: OnMouseLeftButtonDown");
            dragAndDropWindow.OnMouseLeftButtonDown(sender, e);
        }

        private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Main Window: OnMouseLeftButtonUp");
            dragAndDropWindow.OnMouseLeftButtonUp(sender, e);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Trace.WriteLine("Main Window: OnMouseMove");
            dragAndDropWindow.OnMouseMove(sender, e);
        }


    }
}
