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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseClass.bd = new BD();
            CBSup.ItemsSource = BaseClass.bd.Поставщики.ToList();
            CBSup.SelectedValuePath = "ID_поставки";
            CBSup.DisplayMemberPath = "Имя_поставщика";
            CBRespons.ItemsSource = BaseClass.bd.ОтветственныйЗаПоставки.ToList();
            CBRespons.SelectedValuePath = "ID_работника";
            CBRespons.DisplayMemberPath = "Имя_ответственного";
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            WindowList window = new WindowList();
            window.ShowDialog();
        }

        ПоставкиДляКухни Kitchen = new ПоставкиДляКухни();
        ПоставкиДляБара Bar = new ПоставкиДляБара();
        РасходнаяУтварь Stuff = new РасходнаяУтварь();
        ОсобыеПоставки Special = new ОсобыеПоставки();
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int indpost = 0;
            if(RBProduct.IsChecked == true)
            {
                indpost = 1;
            }
            if (RBStuff.IsChecked == true)
            {
                indpost = 2;
            }
            int indsup = CBSup.SelectedIndex + 1;
            int indrespons = CBRespons.SelectedIndex + 1;
            switch (CBTabl.SelectedIndex)
            {
                case 0:
                    //try
                    //{
                        Kitchen.Тип_поставки = indpost;
                        Kitchen.Поставщик = indsup;
                        Kitchen.Описание = TBDescription.Text;
                        Kitchen.Дата = Convert.ToDateTime(DPData.SelectedDate);
                        Kitchen.Ответственный = indrespons;
                        BaseClass.bd.ПоставкиДляКухни.Add(Kitchen);
                        BaseClass.bd.SaveChanges();
                        MessageBox.Show("Поставка для кухни записана!");
                    //}
                    //catch
                    //{
                        //MessageBox.Show("Поставка для кухни не записана!");
                    //}
                    break;
                case 1:
                    try
                    {
                        Bar.Тип_поставки = indpost;
                        Bar.Поставщик = indsup;
                        Bar.Описание = TBDescription.Text;
                        Bar.Дата = Convert.ToDateTime(DPData.SelectedDate);
                        Bar.Ответственный = indrespons;
                        BaseClass.bd.ПоставкиДляБара.Add(Bar);
                        BaseClass.bd.SaveChanges();
                        MessageBox.Show("Поставка для бара записана!");
                    }
                    catch
                    {
                        MessageBox.Show("Поставка для бара не записана!");
                    }
                    break;
                case 2:
                    try
                    {
                        Stuff.Тип_поставки = indpost;
                        Stuff.Поставщики = indsup;
                        Stuff.Описание = TBDescription.Text;
                        Stuff.Дата = Convert.ToDateTime(DPData.SelectedDate);
                        Stuff.Ответственный = indrespons;
                        BaseClass.bd.РасходнаяУтварь.Add(Stuff);
                        BaseClass.bd.SaveChanges();
                        MessageBox.Show("Поставка для принадлежностей записана!");
                    }
                    catch
                    {
                        MessageBox.Show("Поставка для принадлежностей не записана!");
                    }
                    break;
                case 3:
                    try
                    {
                        Special.Тип_поставки = indpost;
                        Special.Поставщик = indsup;
                        Special.Описание = TBDescription.Text;
                        Special.Дата = Convert.ToDateTime(DPData.SelectedDate);
                        Special.Ответственный = indrespons;
                        BaseClass.bd.ОсобыеПоставки.Add(Special);
                        BaseClass.bd.SaveChanges();
                        MessageBox.Show("Особая поставка записана!");
                    }
                    catch
                    {
                        MessageBox.Show("Особая поставка не записана!");
                    }
                    break;
            }
        }
    }
}
