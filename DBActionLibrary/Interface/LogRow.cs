﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DataItemsLibrary;

namespace DBActionLibrary
{
    public class LogRow
    {
        public int ItemId { get; set; }
        public byte[] Timestamp { get; set; }
        public string TableName { get; set; }
        public string ActionType { get; set; }
    }
}
