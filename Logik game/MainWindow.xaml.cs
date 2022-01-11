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

            if (round >= 2)
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
            int contorl1 = 0;
            int contorl2 = 0;

            if (alcol.Contains((S1_1.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4.SelectedIndex))
            {
                contorl1++;
            }
            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1a.Fill = nh;
                if (contorl2 > 1)
                {
                    _2a.Fill = nh;
                    if (contorl2 > 2)
                    {
                        _3a.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4a.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1a.Fill = rh;
                if(contorl1 > 1)
                {
                    _2a.Fill = rh;
                    if(contorl1 > 2)
                    {
                        _3a.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4a.Fill = rh;
                        }
                    }
                }
            }
            


        }
        public void check3()
        {

            int contorl1 = 0;
            int contorl2 = 0;


            if (alcol.Contains((S1_1_Copy.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1b.Fill = nh;
                if (contorl2 > 1)
                {
                    _2b.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3b.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4b.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1b.Fill = rh;
                if (contorl1 > 1)
                {
                    _2b.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3b.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4b.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check4()
        {
            int contorl1 = 0;
            int contorl2 = 0;

            if (alcol.Contains((S1_1_Copy1.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy1.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy1.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy1.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy1.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy1.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy1.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy1.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1c.Fill = nh;
                if (contorl2 > 1)
                {
                    _2c.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3c.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4c.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1c.Fill = rh;
                if (contorl1 > 1)
                {
                    _2c.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3c.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4c.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check5()
        {
            int contorl1 = 0;
            int contorl2 = 0;

            if (alcol.Contains((S1_1_Copy2.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy2.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy2.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy2.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy2.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy2.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy2.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy2.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1d.Fill = nh;
                if (contorl2 > 1)
                {
                    _2d.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3d.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4d.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1d.Fill = rh;
                if (contorl1 > 1)
                {
                    _2d.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3d.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4d.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check6()
        {
            int contorl1 = 0;
            int contorl2 = 0;

            if (alcol.Contains((S1_1_Copy3.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy3.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy3.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy3.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy3.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy3.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy3.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy3.SelectedIndex))
            {
                contorl1++;
            }

            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1e.Fill = nh;
                if (contorl2 > 1)
                {
                    _2e.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3e.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4e.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1e.Fill = rh;
                if (contorl1 > 1)
                {
                    _2e.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3e.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4e.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check7()
        {
            int contorl1 = 0;
            int contorl2 = 0;

            if (alcol.Contains((S1_1_Copy4.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy4.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy4.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy4.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy4.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy4.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy4.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy4.SelectedIndex))
            {
                contorl1++;
            }

            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1f.Fill = nh;
                if (contorl2 > 1)
                {
                    _2f.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3f.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4f.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1f.Fill = rh;
                if (contorl1 > 1)
                {
                    _2f.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3f.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4f.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check8()
        {
            int contorl1 = 0;
            int contorl2 = 0;


            if (alcol.Contains((S1_1_Copy5.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy5.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy5.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy5.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy5.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy5.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy5.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy5.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1g.Fill = nh;
                if (contorl2 > 1)
                {
                    _2g.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3g.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4g.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1g.Fill = rh;
                if (contorl1 > 1)
                {
                    _2g.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3g.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4g.Fill = rh;
                        }
                    }
                }
            }
            
        }
        public void check9()
        {
            int contorl1 = 0;
            int contorl2 = 0;


            if (alcol.Contains((S1_1_Copy6.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy6.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy6.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy6.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy6.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy6.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy6.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy6.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1h.Fill = nh;
                if (contorl2 > 1)
                {
                    _2h.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3h.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4h.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1h.Fill = rh;
                if (contorl1 > 1)
                {
                    _2h.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3h.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4h.Fill = rh;
                        }
                    }
                }
            }
           
        }
        public void check10()
        {
            int contorl1 = 0;
            int contorl2 = 0;


            if (alcol.Contains((S1_1_Copy7.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_2_Copy7.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_3_Copy7.SelectedIndex).ToString()))
            {
                contorl2++;
            }
            if (alcol.Contains((S1_4_Copy7.SelectedIndex).ToString()))
            {
                contorl2++;
            }

            if (rn1 == (S1_1_Copy7.SelectedIndex))
            {
                contorl1++;
            }
            if (rn2 == (S1_2_Copy7.SelectedIndex))
            {
                contorl1++;
            }
            if (rn3 == (S1_3_Copy7.SelectedIndex))
            {
                contorl1++;
            }
            if (rn4 == (S1_4_Copy7.SelectedIndex))
            {
                contorl1++;
            }


            if (contorl1 == 4)
            {
                win();
            }
            if (contorl2 > 0)
            {
                _1i.Fill = nh;
                if (contorl2 > 1)
                {
                    _2i.Fill = nh;
                    if (contorl2 < 2)
                    {
                        _3i.Fill = nh;
                        if (contorl2 > 3)
                        {
                            _4i.Fill = nh;
                        }
                    }
                }
            }
            if (contorl1 > 0)
            {
                _1i.Fill = rh;
                if (contorl1 > 1)
                {
                    _2i.Fill = rh;
                    if (contorl1 < 2)
                    {
                        _3i.Fill = rh;
                        if (contorl1 > 3)
                        {
                            _4i.Fill = rh;
                        }
                    }
                }
            }
            
        }


        public void win()
        {
            MessageBox.Show("You won!");

        }
    }
}
