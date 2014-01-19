﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.Common;

namespace MiaMain
{
    public class FillDataDic : GetData
    {
        protected DataItemsFactory Factory { get; set; }
        public FillDataDic(DataItemsFactory factory)
        {
            Factory = factory;
        }
        protected override DataItem GetDataItem()
        {
            return Factory.GetEmptyDataItem();
        }
        protected override string GetCommandText()
        {
            return DBHelper.GetSelectCommandText(Factory.FirstTableFields, Factory.TableName);
        }
        protected override void Fill(DbDataReader reader, DataItem dataItem)
        {
            base.Fill(reader, dataItem);
            Factory.GetDataItemsDic().Add(dataItem.Id, dataItem);
        }
    }
}
