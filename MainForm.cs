using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoCustomTabControl
{
    public partial class demoCustomTabControlForm : Form
    {
        public demoCustomTabControlForm()
        {
            InitializeComponent();
        }

        private void demoCustomTabControlForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Arial", 9);

            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);

            e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 12, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl.TabPages.Count; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);

                //Getting the position of the “x” mark.

                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);

                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl.TabPages.RemoveAt(i);
                        break;

                    }

                }

            }
        }

        static int KiemTraTonTai(TabControl TabControlName, string TabName)
        {
            int temp = -1;

            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                    return i;
            }
            return temp;

        }

        public void TabCreating(TabControl TabControl, string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);

            if (Index >= 0)
            {
                TabControl.SelectedTab = TabControl.TabPages[Index];

                TabControl.SelectedTab.Text = Text;
            }
            else
            {
                TabPage TabPage = new TabPage { Text = Text };

                TabControl.TabPages.Add(TabPage);

                TabControl.SelectedTab = TabPage;

                Form.TopLevel = false;

                Form.Parent = TabPage;

                Form.Show();

                Form.Dock = DockStyle.Fill;

            }

        }

        private void btnTab1_Click(object sender, EventArgs e)
        {
            ChildrentForm childrentForm = new ChildrentForm("Tab 1");
            TabCreating(tabControl, "Tab 1", childrentForm);
        }

        private void btnTab2_Click(object sender, EventArgs e)
        {
            ChildrentForm childrentForm = new ChildrentForm("Tab 2");
            TabCreating(tabControl, "Tab 2", childrentForm);
        }

        private void btnTab3_Click(object sender, EventArgs e)
        {
            ChildrentForm childrentForm = new ChildrentForm("Tab 3");
            TabCreating(tabControl, "Tab 3", childrentForm);
        }

        private void btnTab4_Click(object sender, EventArgs e)
        {
            ChildrentForm childrentForm = new ChildrentForm("Tab 4");
            TabCreating(tabControl, "Tab 4", childrentForm);
        }

        private void btnTab5_Click(object sender, EventArgs e)
        {
            ChildrentForm childrentForm = new ChildrentForm("Tab 5");
            TabCreating(tabControl, "Tab 5", childrentForm);
        }
    }
}
