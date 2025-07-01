using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCCM
{
    public partial class clubCreation : Form
    {
        public string clubNamePublic => clubName.Text;
        public clubCreation()
        {
            InitializeComponent();
        }

        private void clubCreation_Load(object sender, EventArgs e)
        {

        }

        private void clickToSubmit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
