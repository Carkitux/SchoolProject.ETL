using System;
using System.Collections.Generic;
using System.Text;

namespace ETL_SFC_Model
{
    public static class StagingArea
    {
        public static StagingObject TransformStObject = new StagingObject("TransformStagingObject");
        public static List<StagingObject> StObjects { get; set; } = new List<StagingObject>();
    }
}