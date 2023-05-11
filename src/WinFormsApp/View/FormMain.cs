using SchoolProject.ETL.UI.WinFormsApp.View.FormMainTabs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolProject.ETL.UI.WinFormsApp.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            activeUserControl = new UC0Start();
            activeUserControl.Dock = DockStyle.Fill;
            activeUserControl.Parent = panel1;
        }

        private UserControl activeUserControl;

        private void button2_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UC1Extract(), (Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UC2Transform(), (Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UC3Load(), (Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControlSwitch(new UC4Log(), (Button)sender);
        }

        private void UserControlSwitch(UserControl newUserConrol, Button currentButton)
        {
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;

            var oldUserControl = activeUserControl;
            activeUserControl.Dispose();
            activeUserControl = null;

            if (oldUserControl?.Name == newUserConrol.Name)
            {
                newUserConrol.Dispose();
                activeUserControl = new UC0Start();
            }
            else
            {
                currentButton.BackColor = Color.LightGray;
                activeUserControl = newUserConrol;
            }
            activeUserControl.Dock = DockStyle.Fill;
            activeUserControl.Parent = panel1;

            oldUserControl.Dispose();

            GC.Collect();
        }
    }
}
