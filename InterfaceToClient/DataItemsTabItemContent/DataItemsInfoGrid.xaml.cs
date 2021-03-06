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
    /// Логика взаимодействия для DataItemsGrid.xaml
    /// </summary>
    public abstract partial class DataItemsInfoGrid : Grid
    {

        public DataItemController CurrentDataItem { get { return (DataItemController)DataContext; } }
    }
}
