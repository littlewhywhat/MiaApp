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
using Microsoft.Windows.Controls;

namespace MiaAppInterface
{
    /// <summary>
    /// Логика взаимодействия для DeviceEventGrid.xaml
    /// </summary>
    public partial class DeviceEventGrid : DataItemsInfoGrid
    {
        public DeviceEventGrid()
        {
            InitializeComponent();
            
        }

        public override void RefreshComboBoxes(object DataContext)
        {
            
        }

        public override void RefreshComboBoxes()
        {

        }
    }
}
