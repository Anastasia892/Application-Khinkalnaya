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
    /// Логика взаимодействия для PageBar.xaml
    /// </summary>
    public partial class PageBar : Page
    {
        List<ПоставкиДляБара> BarStart = BaseClass.bd.ПоставкиДляБара.ToList();
        List<ПоставкиДляБара> BarFilter;
        public PageBar()
        {
            InitializeComponent();
            LVShow.ItemsSource = BaseClass.bd.ПоставкиДляБара.ToList();
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
                BarFilter = BarStart.Where(x => x.Дата == DPData.SelectedDate).ToList();
            }
            else
            {
                BarFilter = BarStart;
            }
            int index = CBRespon.SelectedIndex;
            if (CBRespon.SelectedIndex != 0)
            {
                BarFilter = BarFilter.Where(x => x.Ответственный == index).ToList();
            }
            int index2 = CBSup.SelectedIndex;
            if (CBSup.SelectedIndex != 0)
            {
                BarFilter = BarFilter.Where(x => x.Поставщик == index2).ToList();
            }
            int index3 = CBType.SelectedIndex;
            if (CBType.SelectedIndex != 0)
            {
                BarFilter = BarFilter.Where(x => x.Тип_поставки == index3).ToList();
            }

            if (RBDataNew.IsChecked == true)
            {
                BarFilter.Sort((x, y) => x.Дата.CompareTo(y.Дата));
                BarFilter.Reverse();
            }
            if (RBDataOld.IsChecked == true)
            {
                BarFilter.Sort((x, y) => x.Дата.CompareTo(y.Дата));
            }
            if (RBProd.IsChecked == true)
            {
                BarFilter.Sort((x, y) => x.Тип_поставки.CompareTo(y.Тип_поставки));
            }
            if (RBStuff.IsChecked == true)
            {
                BarFilter.Sort((x, y) => x.Тип_поставки.CompareTo(y.Тип_поставки));
                BarFilter.Reverse();
            }
            LVShow.ItemsSource = BarFilter;
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
            FrameClass.frame.Navigate(new PageStuff());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new PageSpeacial());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Uid);
            ПоставкиДляБара del = BaseClass.bd.ПоставкиДляБара.FirstOrDefault(x => x.ID_поставки == id);
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Поставки для бара", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BaseClass.bd.ПоставкиДляБара.Remove(del);
                BaseClass.bd.SaveChanges();
            }
            FrameClass.frame.Navigate(new PageBar());
        }
    }
}
