using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Application_Khinkalnaya
{
    /// <summary>
    /// Логика взаимодействия для WinManual.xaml
    /// </summary>
    public partial class WinManual : Window
    {
        public WinManual()
        {
            InitializeComponent();
            FrameClass.frame_manual = FRManual;
        }

        private void ManuaiWin_add_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.frame_manual.Navigate(new PageManualAdd());
        }

        private void ManualWin_rec_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame_manual.Navigate(new PageManualRec());
        }

        private void ManualWin_fil_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame_manual.Navigate(new PageManualFilt());
        }
    }
}
