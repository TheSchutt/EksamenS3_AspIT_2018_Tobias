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
using ClassBIZ;

namespace EksamenS3_AspIT_2018_Tobias
{
    /// <summary>
    /// Interaction logic for GrainSupplier.xaml
    /// </summary>
    public partial class GrainSupplier : UserControl
    {
        
        ClassBiz CB;
        public GrainSupplier(Grid inGrid, ClassBiz inCB)
        {
            InitializeComponent();
            CB = inCB;
            GrainSupplierGroupBox.DataContext = CB.ClassSupllier;
            SaleAssistantGroupBox.DataContext = CB.ClassSaleAssistant;
            MainGrid = inGrid;
            
        }

        private void CreateSupplierButton_Click(object sender, RoutedEventArgs e)
        {            
            GrainSupplierAdm UCGSA = new GrainSupplierAdm(MainGrid, CB);
            MainGrid.Children.Clear();
            MainGrid.Children.Add(UCGSA);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB.SetSupplierData(sender);
        }
    }
}
