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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : UserControl
    {
        ClassLogin CL;
        
        ClassBiz CB;
        public LogIn(ClassLogin inCL, ClassBiz inCB, Grid inGrid)
        {
            InitializeComponent();
            CL = inCL;
            CB = inCB;
            LoginGrid = inGrid;
            LoginGrid.DataContext = CB;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            CB.classUser = CL.Login(this.user.Text.ToString(), this.pw.Text.ToString());
            if (CB.classUser.UserId == 0)
            {
                MessageBox.Show("Du har indtastet forkert CprNr eller Password");
                this.pw.Clear();
            }
            else
            {
                GrainSupplier UCGS = new GrainSupplier(LoginGrid, CB);
                LoginGrid.Children.Clear();
                LoginGrid.Children.Add(UCGS);
            }
            
        }
    }
}
