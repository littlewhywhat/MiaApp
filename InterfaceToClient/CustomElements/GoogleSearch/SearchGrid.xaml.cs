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
using DataItemsLibrary;
using DataItemControllersLibrary;
namespace InterfaceToClient
{
    /// <summary>
    /// Логика взаимодействия для SearchGrid.xaml
    /// </summary>
    public partial class SearchGrid : Grid
    {
        public SearchGrid()
        {
            InitializeComponent();
            searchPopUp.searchListBox.SelectionChanged += searchListBox_SelectionChanged;
            searchPopUp.searchListBox.DataContextChanged += searchListBox_DataContextChanged;
        }

        void searchListBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            if (searchPopUp.searchListBox.DataContext != searchTextBox.DataContext)
                if (searchPopUp.searchListBox.DataContext.ToString() != "")
                {
                    searchPopUp.searchListBox.Search();
                    if (searchPopUp.searchListBox.HasItems)
                        searchPopUp.IsOpen = true;
                    else
                        searchPopUp.IsOpen = false;
                }
                else
                {
                    searchPopUp.IsOpen = false;
                    searchPopUp.searchListBox.ItemsSource = null;
                }
        }

        void searchListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (FrameworkElement)searchPopUp.searchListBox.SelectedItem;
            if (searchPopUp.searchListBox.SelectedItem != null)
            {
                searchTextBox.DataContext = selectedItem.Tag.ToString();
                searchTextBox.Text = selectedItem.Tag.ToString();
                searchTextBox.DataContext = null;
                selectedItem.BringIntoView();
                searchTextBox.CaretIndex = searchTextBox.Text.Length;
                searchTextBox.Focus();
            }
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (searchPopUp.searchListBox.HasItems)
            {
                if (e.Key == System.Windows.Input.Key.Down)
                {
                    if (!searchPopUp.IsOpen)
                    {
                        searchPopUp.IsOpen = true;
                        if (searchPopUp.searchListBox.SelectedIndex == -1)
                            searchPopUp.searchListBox.SelectedIndex = 0;
                    }
                    else
                        try
                        {
                            searchPopUp.searchListBox.SelectedIndex++;
                        }
                        catch
                        { }
                }
                if (e.Key == System.Windows.Input.Key.Up)
                    try
                    {
                        if (searchPopUp.searchListBox.SelectedIndex != 0)
                            searchPopUp.searchListBox.SelectedIndex--;
                    }
                    catch
                    { }
                if (e.Key == System.Windows.Input.Key.Enter)
                {
                    if (searchPopUp.searchListBox.Items.Count == 1)
                        searchPopUp.searchListBox.SelectedIndex = 0;
                    if (searchPopUp.searchListBox.SelectedIndex > -1)
                    {
                        searchPopUp.IsOpen = false;
                        e.Handled = false;
                        
                    }
                }
            }
        }

        private void searchTextBox_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            searchPopUp.Margin = new Thickness(searchTextBox.Margin.Top, searchTextBox.ActualHeight, searchTextBox.Margin.Right, 0);
            searchPopUp.searchListBox.Width = searchTextBox.ActualWidth;
        }

        private void Grid_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            searchPopUp.searchListBox.SearchDictionary = (DataItemControllersDictionary)DataContext;
        }
    }
}
