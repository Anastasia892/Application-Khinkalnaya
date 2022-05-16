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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Application_Khinkalnaya
{
    /// <summary>
    /// Логика взаимодействия для PageStuff.xaml
    /// </summary>
    public partial class PageStuff : Page
    {
        List<РасходнаяУтварь> StuffStart = BaseClass.bd.РасходнаяУтварь.ToList();
        List<РасходнаяУтварь> StuffFilter;
        public PageStuff()
        {
            InitializeComponent();
            LVShow.ItemsSource = BaseClass.bd.РасходнаяУтварь.ToList();
            CBSup.Items.Add("Все");
            List<Поставщики> sup = BaseClass.bd.Поставщики.ToList();
            for (int i = 0; i < sup.Count; i++)
            {
                CBSup.Items.Add(sup[i].Имя_поставщика);
            }
            CBSup.SelectedIndex = 0;
            CBRespon.Items.Add("Все");
            List<ОтветственныйЗаПоставки> resp = BaseClass.bd.ОтветственныйЗаПоставки.ToList();
            for (int i = 0; i < resp.Count; i++)
            {
                CBRespon.Items.Add(resp[i].Имя_ответственного);
            }
            CBRespon.SelectedIndex = 0;
            CBType.Items.Add("Все");
            List<ТипПоставки> type = BaseClass.bd.ТипПоставки.ToList();
            for (int i = 0; i < type.Count; i++)
            {
                CBType.Items.Add(type[i].Название_типа);
            }
            CBType.SelectedIndex = 0;
        }
        private void Filter()
        {
            if (DPData.SelectedDate != null)
            {
                StuffFilter = StuffStart.Where(x => x.Дата == DPData.SelectedDate).ToList();
            }
            else
            {
                StuffFilter = StuffStart;
            }
            int index = CBRespon.SelectedIndex;
            if (CBRespon.SelectedIndex != 0)
            {
                StuffFilter = StuffFilter.Where(x => x.Ответственный == index).ToList();
            }
            int index2 = CBSup.SelectedIndex;
            if (CBSup.SelectedIndex != 0)
            {
                StuffFilter = StuffFilter.Where(x => x.Поставщики == index2).ToList();
            }
            int index3 = CBType.SelectedIndex;
            if (CBType.SelectedIndex != 0)
            {
                StuffFilter = StuffFilter.Where(x => x.Тип_поставки == index3).ToList();
            }

            if (RBDataNew.IsChecked == true)
            {
                StuffFilter.Sort((x, y) => x.Дата.CompareTo(y.Дата));
                StuffFilter.Reverse();
            }
            if (RBDataOld.IsChecked == true)
            {
                StuffFilter.Sort((x, y) => x.Дата.CompareTo(y.Дата));
            }
            if (RBProd.IsChecked == true)
            {
                StuffFilter.Sort((x, y) => x.Тип_поставки.CompareTo(y.Тип_поставки));
            }
            if (RBStuff.IsChecked == true)
            {
                StuffFilter.Sort((x, y) => x.Тип_поставки.CompareTo(y.Тип_поставки));
                StuffFilter.Reverse();
            }
            LVShow.ItemsSource = StuffFilter;
            LVShow.Items.Refresh();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void CBRespon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void CBSup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void CBType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void RBDataNew_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void RBDataOld_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void RBProd_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void RBStuff_Checked(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new PageKitchen());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new PageBar());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new PageSpeacial());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Uid);
            РасходнаяУтварь del = BaseClass.bd.РасходнаяУтварь.FirstOrDefault(x => x.ID_поставки == id);
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Поставки принадлежностей", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BaseClass.bd.РасходнаяУтварь.Remove(del);
                BaseClass.bd.SaveChanges();
            }
            FrameClass.frame.Navigate(new PageStuff());
        }
    }
}
