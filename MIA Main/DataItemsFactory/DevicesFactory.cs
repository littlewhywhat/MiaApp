﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MiaMain
{
    public class DevicesFactory : DataItemsFactory
    {
        private List<string> firstTableFields = new List<String> { "Id", "Name", "ParentId", "CompanyId" };
        private List<string> otherTableFields = new List<String> { "FullName", "IVUK", "ProductNumber" };
        private string tableName = "Devices";
        
        public override List<string> FirstTableFields { get { return firstTableFields; } }
        public override List<string> OtherTableFields { get { return otherTableFields; } }
        public override string TableName { get { return tableName; } }

        public override DataItem GetEmptyDataItem()
        {
            return new Device(this);
        }

        protected override void DeleteReferences(DataItem dataItem, System.Data.Common.DbTransaction transaction)
        {
            FactoriesVault.FactoriesDic["DeviceEvents"].GetDataItemsDic().Values.ForEach(deviceEvent =>
                {
                    if (((DeviceEvent)deviceEvent).DeviceId == dataItem.Id)
                        deviceEvent.Delete();
                });
            base.DeleteReferences(dataItem, transaction);
        }
    }
}
