using System.Windows;
using System.Windows.Controls;

namespace Northwind.Gui.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            masterSelectorUserControl.Content = new UserControls.MasterSelectorUserControl();
            instance = this;
        }

        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            string text = $"Assembly version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            MessageBox.Show(text, "Om Northwind", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void SetDetailsUserControlTo(UserControl userControl)
        {
            detailsUserControl.Content = userControl;
        }

        public static MainWindow Instance
        {
            get
            {
                return instance;
            }
        }
    }
}