﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MiaMain;
namespace MiaAppInterface
{
    /// <summary>
    /// Логика взаимодействия для DevicesGrid.xaml
    /// </summary>
    public partial class DevicesGrid : DataItemsGrid
    {
        public DevicesGrid()
        {
            InitializeComponent();
        }
        private void DevicesGrid_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var device = DataContext as Device;
            DevicesParentComboBox.RefreshDataContext(DataContext);
            DevicesCompanyIdComboBox.RefreshDataContext(DataContext);
        }


    }
}
