using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightMarquee
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void canvas1_Loaded(object sender, RoutedEventArgs e)
        {
            ScrollText.Text = " is this getting changed from here?"; // no it shouldn't this should be a passing test
            for (int i = 0; i < 10; i++)
            {
                var r = new Random();
                // print random integer >= 1 and  < 10
                ScrollText.Text = (r.Next(1,10)).ToString();
                //ScrollText2.Source =  not sure how to do this yet once i have it this should be what your wanting
            }
        }

        
    }
}
