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
    /// Interaction logic for GrainSupplierAdm.xaml
    /// </summary>
    public partial class GrainSupplierAdm : UserControl
    {
        ClassBiz CB;
        public GrainSupplierAdm(Grid inGrid, ClassBiz inCB)
        {
            InitializeComponent();
            GridSupplierAdm = inGrid;
            CB = inCB;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            CB.CreateSupplier();
        }

        private void RegretButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
