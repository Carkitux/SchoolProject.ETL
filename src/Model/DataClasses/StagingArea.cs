using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject.ETL.Model.DataClasses
{
    public static class StagingArea
    {
        // Propertys
        public static StagingObject TransformStObject { get; private set; } = new StagingObject("TransformStagingObject");
        public static StagingObject SplitMergeStObject { get; private set; } = new StagingObject("SplitMerge");
        public static List<StagingObject> StObjects { get; private set; } = new List<StagingObject>();

        // Methods
        public static StagingObject GetStagingObject(string stagingObjectName)
        {
            var stagingObject = StObjects.Where(x => x.Name == stagingObjectName).FirstOrDefault();
            if (stagingObject == null)
            { 
                if (stagingObjectName == TransformStObject.Name)
                {
                    stagingObject = TransformStObject;
                }
                if (stagingObjectName == SplitMergeStObject.Name)
                {
                    stagingObject = SplitMergeStObject;
                }
            }
            return stagingObject;
        }
    }
}