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

namespace Master_pol_Drachev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        PartnersContext partners;
        public List<PartnersContext> partnersContexts = PartnersContext.AllPartners();
        public Main()
        {
            InitializeComponent();
            CreateUI();
        }
        public void CreateUI()
        {
            parrent.Children.Clear();
            foreach (PartnersContext item in partnersContexts)
            {
                parrent.Children.Add(new Elements.);
            }
        }
    }
}
