namespace SchoolProject.ETL.Model.LogicClasses
{
    public class Helper
    {
        public static string GetFileName(string path)
        {
            var filePath = path.Split('\\');
            var fileName = filePath[^1];
            return fileName;
        }
    }
}
