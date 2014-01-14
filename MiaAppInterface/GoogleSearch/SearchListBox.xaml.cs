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
using MiaMain;
namespace MiaAppInterface
{
    /// <summary>
    /// Логика взаимодействия для SearchListBox.xaml
    /// </summary>
    public partial class SearchListBox : ListBox
    {
        public SearchListBox()
        {
            InitializeComponent();
        }
        public void Search(DataItemsFactory factory)
        {
            //Items.Clear();
            var searchCriteria = DataContext.ToString();
            ItemsSource = factory.GetDataItemsDic().Where(item => item.Key.ToString().Contains(searchCriteria));
            //factory.GetDataItemsDic().ForEach(item =>
            //{
            //    if (item.Key.ToString() == searchCriteria)
            //        Items.Add(new ListBoxItem() { Content = ((Company)item.Value).Name });
            //});
            
            //var block = new TextBlock();
            //block.Text = "hi";
            //var panel = new StackPanel();
            //panel.Children.Add(block);
            //Items.Add(new ListBoxItem() { Content =  panel});
            //Items.Add(new ListBoxItem() { Content = panel });
            //Items.Add(new ListBoxItem() { Content = panel });
            //var grid = Parent as Grid;
            //var popUp = grid.Parent as SearchPopUp;
            //popUp.IsOpen = true;
            //((SearchPopUp)(this.Parent.Parent).IsOpen = true;
        }
    }
}