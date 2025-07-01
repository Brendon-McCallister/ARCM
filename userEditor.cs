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
    public partial class userEditor : Form
    {
     
        public userEditor()
        {
            InitializeComponent();
        }

        private void userEditor_Load(object sender, EventArgs e)
        {

        }

        private Image img;
        private void uploadImg(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select an Image";
                openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openDialog.FileName;

                    Image img = Image.FromFile(selectedFile);
                }
            }
        }

        public Image ImagePublic => img;
        public string NamePublic => name.Text; //
        public string PhoneNumPublic => phoneNum.Text; //
        public string ExpirationDatePublic => expirationDate.Text; //

        public string DOBPublic => dateOfBirth.Text; //
        public string MemberIDPublic => memberID.Text; //
        public string UserRolePublic => userRole.Text; //
        public string UserAddressPublic => Address.Text; //
        public string Line1Public => line1.Text; //
        public string Line2Public => line2.Text; //

        private void submit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
