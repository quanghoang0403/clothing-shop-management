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

namespace _410ShopManagement._401UC
{
    /// <summary>
    /// Interaction logic for PaymentUC.xaml
    /// </summary>
    public partial class PaymentUC : UserControl
    {
        //windows
        TransactionHistoryWindow transactionHistoryWnd = new TransactionHistoryWindow();

        public PaymentUC()
        {
            InitializeComponent();
        }

        private void paymentBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void historyBtn_Click(object sender, RoutedEventArgs e)
        {
            transactionHistoryWnd.ShowDialog();
        }
    }
}
