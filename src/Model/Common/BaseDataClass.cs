using System;

namespace SchoolProject.ETL.Model.Common
{
    public abstract class BaseDataClass
    {
        // Constructors
        public BaseDataClass()
        {

        }

        // Propertys
        public Guid ID { get; internal set; } = Guid.NewGuid();
    }
}
