using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.Helper
{
    public class TabPageHelper
    {
        public static TabPage Create(string name, TabControl tabControl)
        {
            // Erstellt einen neuen Reiter mit dem Dateinamen
            var tabPage = new TabPage
            {
                Text = name
            };

            // Weißt die erstellte TabPage der TabControl hinzu
            tabControl.TabPages.Add(tabPage);

            return tabPage;
        }

        public static bool ExistsInTabControl(string name, TabControl tabControl)
        {
            // Checkt ob es die Page bereits in diesem TabControl gibt
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Text == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
