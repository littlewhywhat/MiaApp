﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MiaAppInterface
{
    /// <summary>
    /// Логика взаимодействия для DataItemsTabControl.xaml
    /// </summary>
    public partial class DataItemsTabControl : TabControl
    {
        public DataItemsTabControl()
        {
            InitializeComponent();
        }
        private void DataItemsTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tabControl = sender as TabControl;
            if (!(tabControl.SelectedItem is DataItemsTabItem))
                if (e.RemovedItems.Count != 0)
                    ((DataItemsTabItem)e.RemovedItems[0]).IsSelected = true;
        }
        private void Insert_Click(object sender, MouseButtonEventArgs e)
        {
            var tabItem = ((DataItemsController)DataContext).GetInsertTabItem();
            Items.Add(tabItem);
            tabItem.IsSelected = true;
        }
    }
}
