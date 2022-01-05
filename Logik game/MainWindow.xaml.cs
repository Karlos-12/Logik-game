using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Logik_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rn1 = 0;
        int rn2 = 0;
        int rn3 = 0;
        int rn4 = 0;

        string alcol = null;

        int round = 0;
        SolidColorBrush _1 = new SolidColorBrush();
        SolidColorBrush _2 = new SolidColorBrush();
        SolidColorBrush _3 = new SolidColorBrush();
        SolidColorBrush _4 = new SolidColorBrush();

        SolidColorBrush rh = new SolidColorBrush();
        SolidColorBrush nh = new SolidColorBrush();



        public MainWindow()
        {
            InitializeComponent();

            _1.Color = Color.FromRgb(255, 0, 0);
            _2.Color = Color.FromRgb(0, 255, 0);
            _3.Color = Color.FromRgb(134, 1, 175);
            _4.Color = Color.FromRgb(255, 255, 0);

            rh.Color = Color.FromRgb(0, 0, 0);
            nh.Color = Color.FromRgb(255, 255, 255);

        }




        private void c1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var s = (ComboBox)sender;



            var r = (Rectangle)s.Tag;

            if (round == 2)
            {
                if (s.SelectedIndex == 0)
                {
                    r.Fill = _1;
                }
                if (s.SelectedIndex == 1)
                {
                    r.Fill = _2;
                }
                if (s.SelectedIndex == 2)
                {
                    r.Fill = _3;
                }
                if (s.SelectedIndex == 3)
                {
                    r.Fill = _4;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            round = 2;
            test.IsEnabled = false;
            S1_1.IsEnabled = true;
            S1_2.IsEnabled = true;
            S1_3.IsEnabled = true;
            S1_4.IsEnabled = true;
            Random rn = new Random();
            rn1 = rn.Next(3);
            rn2 = rn.Next(3);
            rn3 = rn.Next(3);
            rn4 = rn.Next(3);

            alcol = rn1.ToString() + rn2.ToString() + rn3.ToString() + rn4.ToString();
            _12.Content = alcol;

        }

        private void chl_Click(object sender, RoutedEventArgs e)
        {

            if (round == 2)
            {
                check2();
                S1_1.IsEnabled = false;
                S1_2.IsEnabled = false;
                S1_3.IsEnabled = false;
                S1_4.IsEnabled = false;

                S1_1_Copy.IsEnabled = true;
                S1_2_Copy.IsEnabled = true;
                S1_3_Copy.IsEnabled = true;
                S1_4_Copy.IsEnabled = true;
            }
            else if (round == 3)
            {
                check3();
                S1_1_Copy.IsEnabled = false;
                S1_2_Copy.IsEnabled = false;
                S1_3_Copy.IsEnabled = false;
                S1_4_Copy.IsEnabled = false;

                S1_1_Copy1.IsEnabled = true;
                S1_2_Copy1.IsEnabled = true;
                S1_3_Copy1.IsEnabled = true;
                S1_4_Copy1.IsEnabled = true;
            }
            else if (round == 4)
            {
                check4();
                S1_1_Copy1.IsEnabled = false;
                S1_2_Copy1.IsEnabled = false;
                S1_3_Copy1.IsEnabled = false;
                S1_4_Copy1.IsEnabled = false;

                S1_1_Copy2.IsEnabled = true;
                S1_2_Copy2.IsEnabled = true;
                S1_3_Copy2.IsEnabled = true;
                S1_4_Copy2.IsEnabled = true;
            }
            else if (round == 5)
            {
                check5();
                S1_1_Copy2.IsEnabled = false;
                S1_2_Copy2.IsEnabled = false;
                S1_3_Copy2.IsEnabled = false;
                S1_4_Copy2.IsEnabled = false;

                S1_1_Copy3.IsEnabled = true;
                S1_2_Copy3.IsEnabled = true;
                S1_3_Copy3.IsEnabled = true;
                S1_4_Copy3.IsEnabled = true;
            }
            else if (round == 6)
            {
                check6();
                S1_1_Copy3.IsEnabled = false;
                S1_2_Copy3.IsEnabled = false;
                S1_3_Copy3.IsEnabled = false;
                S1_4_Copy3.IsEnabled = false;

                S1_1_Copy4.IsEnabled = true;
                S1_2_Copy4.IsEnabled = true;
                S1_3_Copy4.IsEnabled = true;
                S1_4_Copy4.IsEnabled = true;
            }
            else if (round == 7)
            {
                check7();
                S1_1_Copy4.IsEnabled = false;
                S1_2_Copy4.IsEnabled = false;
                S1_3_Copy4.IsEnabled = false;
                S1_4_Copy4.IsEnabled = false;

                S1_1_Copy5.IsEnabled = true;
                S1_2_Copy5.IsEnabled = true;
                S1_3_Copy5.IsEnabled = true;
                S1_4_Copy5.IsEnabled = true;
            }
            else if (round == 8)
            {
                check8();
                S1_1_Copy5.IsEnabled = false;
                S1_2_Copy5.IsEnabled = false;
                S1_3_Copy5.IsEnabled = false;
                S1_4_Copy5.IsEnabled = false;

                S1_1_Copy6.IsEnabled = true;
                S1_2_Copy6.IsEnabled = true;
                S1_3_Copy6.IsEnabled = true;
                S1_4_Copy6.IsEnabled = true;
            }
            else if (round == 9)
            {
                check9();
                S1_1_Copy6.IsEnabled = false;
                S1_2_Copy6.IsEnabled = false;
                S1_3_Copy6.IsEnabled = false;
                S1_4_Copy6.IsEnabled = false;


                S1_1_Copy7.IsEnabled = true;
                S1_2_Copy7.IsEnabled = true;
                S1_3_Copy7.IsEnabled = true;
                S1_4_Copy7.IsEnabled = true;

            }
            if (round == 10)
            {
                check10();
            }
            round++;
        }

        public void check2()

        {
            int contorl = 4;

            if (alcol.Contains((S1_1.SelectedIndex).ToString()))
            {
                _1a.Fill = nh;
            }
            if (alcol.Contains((S1_2.SelectedIndex).ToString()))
            {
                _2a.Fill = nh;
            }
            if (alcol.Contains((S1_3.SelectedIndex).ToString()))
            {
                _3a.Fill = nh;
            }
            if (alcol.Contains((S1_4.SelectedIndex).ToString()))
            {
                _4a.Fill = nh;
            }

            if (rn1 == (S1_1.SelectedIndex))
            {
                contorl--;
                _1a.Fill = rh;
            }
            if (rn2 == (S1_2.SelectedIndex))
            {
                contorl--;
                _2a.Fill = rh;
            }
            if (rn3 == (S1_3.SelectedIndex))
            {
                contorl--;
                _3a.Fill = rh;
            }
            if (rn4 == (S1_4.SelectedIndex))
            {
                contorl--;
                _4a.Fill = rh;
            }
            if (contorl == 0)
            {
                win();

            }


        }
        public void check3()
        {

        }
        public void check4()
        {

        }
        public void check5()
        {

        }
        public void check6()
        {

        }
        public void check7()
        {

        }
        public void check8()
        {

        }
        public void check9()
        {

        }
        public void check10()
        {

        }


        public void win()
        {
            MessageBox.Show("You won!");

        }


    }
}
