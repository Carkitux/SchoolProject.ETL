using System;

namespace SchoolProject.ETL.Model.Common
{
    public abstract class BaseDataClass
    {
        public BaseDataClass()
        {

        }

        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
