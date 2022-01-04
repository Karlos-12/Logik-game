using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Logik_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int round = 0;
        SolidColorBrush _1 = new SolidColorBrush();
        SolidColorBrush _2 = new SolidColorBrush();
        SolidColorBrush _3 = new SolidColorBrush();
        SolidColorBrush _4 = new SolidColorBrush();


        public MainWindow()
        {
            InitializeComponent();
            round = 1;
            _1.Color = Color.FromRgb(255, 0, 0);
            _2.Color = Color.FromRgb(0, 255, 0);
            _3.Color = Color.FromRgb(134, 1, 175);
            _4.Color = Color.FromRgb(255, 255, 0);

            
        }
     

       

        private void c1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            if (S1_1.SelectedIndex == 0)
            {
                C1_1.Fill = _1;
            }
            if (S1_1.SelectedIndex == 1)
            {
                C1_1.Fill = _2;
            }
            if (S1_1.SelectedIndex == 2)
            {
                C1_1.Fill = _3;
            }
            if (S1_1.SelectedIndex == 3)
            {
                C1_1.Fill = _4;
            }
        }

       private void c1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
       {
            var s = (ComboBox)sender;
           if (S1_2.SelectedIndex == 0)
           {
               C1_2.Fill = _1;
           }
          if (S1_2.SelectedIndex == 1)
           {
               C1_2.Fill = _2;
           }
           if (S1_2.SelectedIndex == 2)
           {
              C1_2.Fill = _3;
           }
           if (S1_2.SelectedIndex == 3)
           {
               C1_2.Fill = _4;
           }

        }
    }
}
