using SchoolProject.ETL.Model.DataClasses.StagingObjectAgr;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.ETL.Model.DataClasses
{
    public static class StagingArea
    {
        public static StagingObject TransformStObject = new StagingObject("TransformStagingObject");
        public static List<StagingObject> StObjects { get; set; } = new List<StagingObject>();
    }
}