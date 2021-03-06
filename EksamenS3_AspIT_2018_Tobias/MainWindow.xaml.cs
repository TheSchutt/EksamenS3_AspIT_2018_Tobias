﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiz CB = new ClassBiz();
        ClassLogin CL = new ClassLogin();
        public MainWindow()
        {
            InitializeComponent();
            CB.MakeDataBase();
            LogIn logIn = new LogIn(CL,CB,this.MainGrid);
            this.MainGrid.Children.Clear();
            this.MainGrid.Children.Add(logIn);
        
        }
    }
}
