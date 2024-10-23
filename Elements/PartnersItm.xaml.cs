using Master_pol_Drachev.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Master_pol_Drachev.Elements
{
    /// <summary>
    /// Логика взаимодействия для PartnersItm.xaml
    /// </summary>
    public partial class PartnersItm : UserControl
    {
        public PartnersContext partners;
        public PartnersItm(PartnersContext item)
        {
            if (item != null)
            {
                InitializeComponent();
                partners = item;
                type_text.Content = TypePartnersContext.AllTypePartners().Find(x => x.id == item.type).name;
                name_text.Content = "| " + item.name;
                if (PartnerProductsContext.AllPartnerProducts().Find(x => x.id == item.id) != null)
                {
                    int skidCount = PartnerProductsContext.AllPartnerProducts().Find(x => x.id == item.id).count;               
                    if (skidCount < 10000) skidka_text.Content = "0%";
                    if (skidCount > 10000 && skidCount < 50000) skidka_text.Content = "5%";
                    if (skidCount > 50000 && skidCount < 300000) skidka_text.Content = "10%";
                    if (skidCount > 300000) skidka_text.Content = "15%";
                }
                else skidka_text.Content = "0%";
                fio_text.Content = item.fio;
                rating_text.Content = "Рейтинг: " + item.rating;
                phone_text.Content = item.phone;
                email_text.Content = item.email;
                
            }
            else
            {
                MessageBox.Show("Ошибка вывода информации!");
            }

        }

        private void Click_redact(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Partners_Add(partners));
        }
    }
}
