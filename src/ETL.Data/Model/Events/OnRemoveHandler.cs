using System;
using System.Collections.Generic;
using System.Text;

namespace BKTSIWI.ITT421.LF08.ETLProcess.Model.Events
{
    public delegate void MyRemovingFromCollectionEventHandler(object sender);

    public class MyRemovingFromCollectionEventArgs : EventArgs
    {
        private string EventInfo;
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
