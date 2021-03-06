﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using DataItemsLibrary;

namespace DBActionLibrary
{
    
    [Serializable()]
    public class DBActionException : System.Exception
    {
        const string _exceptionMessage = "There was an error during transaction. Try again.";
        public DBActionException() : base() { }
        public DBActionException(string message) : base(message) { }
        public DBActionException(string message, System.Exception inner) : base(message, inner) { }
        public DBActionException(System.Exception inner) : base(_exceptionMessage, inner) { }
        public void ShowMessageBox()
        {
            MessageBox.Show( _exceptionMessage, "Error" , MessageBoxButton.OK);
        }
        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected DBActionException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
