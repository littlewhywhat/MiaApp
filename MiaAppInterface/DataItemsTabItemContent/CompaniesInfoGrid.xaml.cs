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
using MiaMain;

namespace MiaAppInterface
{
    /// <summary>
    /// Логика взаимодействия для CompaniesTabItemContent.xaml
    /// </summary>
    public partial class CompaniesInfoGrid : DataItemsInfoGrid
    {
        public CompaniesInfoGrid()
        {
            InitializeComponent();   
        }

        public override void RefreshComboBoxes(object dataContext)
        {
            CompanyParentComboBox.RefreshDataContext(dataContext);
        }

        public override void RefreshComboBoxes()
        {
            CompanyParentComboBox.RefreshDataContext(DataContext);
        }
    }
}