﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataItemsLibrary
{
    public class DeviceEventsFactory : DataItemsFactory
    {
        private List<string> firstTableFields = new List<String> { "Id", "Name", "DeviceId", "Type", "Date" };
        private List<string> otherTableFields = new List<String> { "Date" };
        private List<string> searchTableFields = new List<String> {  };

        public override List<string> FirstTableFields { get { return firstTableFields; } }
        public override List<string> SearchTableFields { get { return searchTableFields; } }
        public override List<string> OtherTableFields { get { return otherTableFields; } }

        public override string TableName { get { return TableNames.DeviceEvents; } }

        public override DataItem GetEmptyDataItem()
        {
            return new DeviceEvent(this);
        }

        public override DataItem GetDataItemDefault()
        {
            var dataItem = (DeviceEvent)GetEmptyDataItem();
            dataItem.Name = "New event";
            dataItem.Date = DateTime.Now;
            dataItem.Type = "Type undefined";
            return dataItem;
        }
    }
}
