using BKTSIWI.ITT421.LF08.ETLProcess.Model.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Library.Model.Common
{
    public class BaseDataClass
    {
        private event MyRemovingFromCollectionEventHandler OnRemovingFromCollection;

        public BaseDataClass()
        {
            OnRemovingFromCollection += RemovedFromList;
        }

        public Guid ID { get; set; } = Guid.NewGuid();

        protected virtual void RemovedFromList(object sender)
        {
            throw new NotImplementedException();
        }

        public void RaiseRemovingFromListEvent(object sender)
        {
            OnRemovingFromCollection?.Invoke(sender);
        }
    }
}
