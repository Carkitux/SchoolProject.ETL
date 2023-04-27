namespace SchoolProject.ETL.ModelLogic.Common
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
