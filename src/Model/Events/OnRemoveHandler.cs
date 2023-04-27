using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.ETL.Model.Events
{
    public delegate void MyRemovingFromCollectionEventHandler(object sender);

    public class MyRemovingFromCollectionEventArgs : EventArgs
    {
        private readonly string EventInfo;
        public MyRemovingFromCollectionEventArgs(string Text)
        {
            EventInfo = Text;
        }
        public string GetInfo()
        {
            return EventInfo;
        }
    }
}
