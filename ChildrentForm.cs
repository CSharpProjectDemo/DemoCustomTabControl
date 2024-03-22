using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCustomTabControl
{
    public partial class ChildrentForm : Form
    {
        public ChildrentForm()
        {
            InitializeComponent();
        }

        public ChildrentForm(string titleForm)
        {
            InitializeComponent();
            label1.Text = titleForm;
        }

        private void ChildrentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
