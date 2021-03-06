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
using System.Collections.Specialized;
using DataItemsLibrary;
using DataItemControllersLibrary;
namespace InterfaceToClient
{
    public partial class DataItemsTabItem : TabItem, IObserver, IClose
    {
        public DataItemController CurrentDataItemController { get { return (DataItemController)DataContext; } }
        
        public DataItemsTabItem()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            CloseTabItem();
        }

        public void CloseTabItem()
        {
            var tabControl = (TabControl)this.Parent;
            tabControl.Items.Remove(this);
            Dispose();        
        }

        public void Update(DataItemControllerChangedEventArgs Change)
        {
            try
            { 
                if  (Change.NewController == CurrentDataItemController ||
                    Change.OldController == CurrentDataItemController)
                {
                    
                    if ((Change.Action == NotifyCollectionChangedAction.Remove))
                        CurrentDataItemController.GetInInsertMode();
                    else
                        CurrentDataItemController.RefreshDataItemByController(Change.NewController);
                    return;
                }
                CurrentDataItemController.Refresh();
                
            }
            catch (Exception)
            { }
        }

        void IClose.Close(ControlManager manager)
        {
            CloseTabItem();
        }

        public void Dispose()
        {
            Vault.ChangesGetter.RemoveObserver(this);
            ((FrameworkElement)Content).DisposeChildrenObservers();   
        }
    }
}
