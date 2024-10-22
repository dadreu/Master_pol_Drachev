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
                skidka_text.Content = "10%";
                fio_text.Content = item.fio;
                phone_text.Content = item.contact;
                rating_text.Content = "Рейтинг: " + item.rating;
            }
            else
            {
                MessageBox.Show("Ошибка вывода информации!");
            }

        }
    }
}
