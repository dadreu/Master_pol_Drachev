using Master_pol_Drachev.Classes;
using Master_pol_Drachev.Models;
using MySql.Data.MySqlClient;
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

namespace Master_pol_Drachev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Partners_Add.xaml
    /// </summary>
    public partial class Partners_Add : Page
    {
        PartnersContext partnersContext;
        public Partners_Add(PartnersContext redactPartner)
        {
            InitializeComponent();
            partnersContext = redactPartner;
            if(redactPartner == null)
            {
                foreach (TypePartners typePartners in TypePartnersContext.AllTypePartners())
                {
                    ComboBoxItem comboBoxItem = new ComboBoxItem()
                    {
                        Content = typePartners.name,
                        Tag = typePartners.id
                    };
                    type_text.Items.Add(comboBoxItem);
                }
            }
            
            if (redactPartner != null)
            {
                PartnersContext loadPartner = PartnersContext.AllPartners().Find(x => x.id == redactPartner.id);
                name_text.Text = loadPartner.name;
                foreach(TypePartners typePartners in TypePartnersContext.AllTypePartners())
                {
                    ComboBoxItem comboBoxItem = new ComboBoxItem()
                    {
                        Content = typePartners.name,
                        Tag = typePartners.id
                    };
                    if (redactPartner.type == (int)comboBoxItem.Tag)
                        comboBoxItem.IsSelected = true;
                    type_text.Items.Add(comboBoxItem);
                }
                rating_text.Text = loadPartner.rating.ToString();
                adres_text.Text = loadPartner.adres;
                fio_text.Text = loadPartner.fio;
                phone_text.Text = loadPartner.phone.ToString();
                email_text.Text = loadPartner.email;
                inn_text.Text = loadPartner.email;
            }
        }

        private void Click_Save(object sender, RoutedEventArgs e)
        {
            if (partnersContext != null)
            {
                MySqlConnection connection = DbConnection.OpenConnection();
                var pc = DbConnection.Query($"UPDATE ISP_21_2_5.partners SET type = '{(type_text.SelectedItem as ComboBoxItem).Tag}', name = '{name_text.Text}', fio = '{fio_text.Text}', adres = '{adres_text.Text}', inn = '{inn_text.Text}', phone = '{phone_text.Text}', email = '{email_text.Text}', rating = '{rating_text.Text}' WHERE id = {partnersContext.id};", connection);
                if (pc != null)
                {
                    MessageBox.Show("Успешное изменение информации о партнёре");
                    DbConnection.CloseConnection(connection);
                    MainWindow.init.frame.Navigate(new Pages.Main());
                }
                else
                {
                    MessageBox.Show("Проверьте заполнение данных");
                }
            }
            else if (partnersContext == null)
            {
                MySqlConnection connection = DbConnection.OpenConnection();
                var pc = DbConnection.Query($"INSERT INTO ISP_21_2_5.partners(type, name, fio, adres, inn, phone, email, rating) VALUES ('{(type_text.SelectedItem as ComboBoxItem).Tag}', '{name_text.Text}','{fio_text.Text}', '{adres_text.Text}', '{inn_text.Text}', '{phone_text.Text}', '{email_text.Text}', '{rating_text.Text}');", connection);
                if (pc != null)
                {
                    MessageBox.Show("Успешное добавление информации о партнёре");
                    DbConnection.CloseConnection(connection);
                    MainWindow.init.frame.Navigate(new Pages.Main());
                }
                else
                {
                    MessageBox.Show("Проверьте заполнение данных");
                }
            }
        }

        private void Click_Cancel(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new Pages.Main());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.init.Close();
        }
    }
}
