using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCCM.userCreation
{
    public partial class userCreation : Form
    {
        public string Callsign => callsignSubmitted.Text;
        public string NameOfUser => nameOfUser.Text;

        public userCreation()
        {
            InitializeComponent();
        }

        private void submitClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void userCreation_Load(object sender, EventArgs e)
        {

        }
    }

}
