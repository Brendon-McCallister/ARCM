using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARCCM
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();

            var userViewer = clubUserViewer;
            foreach (TreeNode root in clubUserViewer.Nodes)
                SetNodeIcons(root);
            string appDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ARCM"
            );
            string appSaveDir = Path.Combine(appDir, "sav");
            if (Directory.Exists(appSaveDir))
                LoadTree(Path.Combine(appSaveDir, "arcm.sav"));
            else
            {
                MessageBox.Show("No Previous Save data found. You can import it via the import function.");
            }
            groupBox.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // <- Real Code past here -------------------------------------------------------------->

        void SetNodeIcons(TreeNode node)
        {
            if (node.Level == 0)
            {
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }
            else
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }

            foreach (TreeNode child in node.Nodes)
            {
                SetNodeIcons(child);
            }
        }
        // TreeNode Save
        public class TreeNodeData
        {
            public string Text { get; set; }
            public int ImageIndex { get; set; }
            public string EmbeddedImageBase64 { get; set; }
            public List<TreeNodeData> Children { get; set; } = new List<TreeNodeData>();
        }
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        private static Image ConvertBase64ToImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }


        private TreeNodeData ConvertToData(TreeNode node)
        {
            var data = new TreeNodeData
            {
                Text = node.Text,
                ImageIndex = node.ImageIndex
            };

            foreach (TreeNode child in node.Nodes)
            {
                data.Children.Add(ConvertToData(child));
            }

            return data;
        }

        private static TreeNode ConvertToTreeNode(TreeNodeData data)
        {
            /*
            var node = new TreeNode(data.Text)
            {
                ImageIndex = data.ImageIndex,
                SelectedImageIndex = data.ImageIndex
            };

            foreach (var childData in data.Children)
            {
                node.Nodes.Add(ConvertToTreeNode(childData));
            } */
            TreeNode node = new TreeNode(data.Text)
            {
                ImageIndex = data.ImageIndex,
                SelectedImageIndex = data.ImageIndex
            };

            if (!string.IsNullOrEmpty(data.EmbeddedImageBase64))
            {
                node.Tag = ConvertBase64ToImage(data.EmbeddedImageBase64);
            }

            return node;
        }

        // Save
        private void SaveTree(string filePath)
        {
            var allData = new List<TreeNodeData>();
            foreach (TreeNode node in clubUserViewer.Nodes)
            {
                allData.Add(ConvertToData(node));
            }

            string json = System.Text.Json.JsonSerializer.Serialize(allData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void saveOnClick(object sender, EventArgs e)
        {
            string appDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ARCM"
            );
            string appSaveDir = Path.Combine(appDir, "sav");
            if (!Directory.Exists(appSaveDir))
                Directory.CreateDirectory(appSaveDir);

            SaveTree(Path.Combine(appSaveDir, "arcm.sav"));
        }

        // Load
        private void LoadTree(string filePath)
        {
            if (!File.Exists(filePath)) return;

            string json = File.ReadAllText(filePath);
            var data = System.Text.Json.JsonSerializer.Deserialize<List<TreeNodeData>>(json);

            clubUserViewer.Nodes.Clear();
            foreach (var item in data)
            {
                clubUserViewer.Nodes.Add(ConvertToTreeNode(item));
            }
        }
        private void clickToExport(object sender, EventArgs e)
        {
            string appFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ARCM",
                "sav"
            );
            string originalFile = Path.Combine(appFolder, "arcm.sav");

            saveOnClick(sender, e);

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Export Save File";
                saveDialog.Filter = "Save files (*.sav)|*.sav";
                saveDialog.FileName = "exported.sav";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(originalFile, saveDialog.FileName, overwrite: true);
                    MessageBox.Show("Save file copied successfully!");
                }
            }

        }

        private void clickToImport(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will loose your save file. Continue?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    openDialog.Title = "Import Save File";
                    openDialog.Filter = "Save files (*.sav)|*.sav";

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string json = File.ReadAllText(openDialog.FileName);
                            var data = System.Text.Json.JsonSerializer.Deserialize<List<TreeNodeData>>(json);

                            clubUserViewer.Nodes.Clear();
                            foreach (var item in data)
                            {
                                clubUserViewer.Nodes.Add(ConvertToTreeNode(item));
                            }

                            MessageBox.Show("Tree imported successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error importing file:\n{ex.Message}");
                        }
                    }
                }
            }
        }

        /********************Making Users***************************/
        public class UserData
        {
            public string Name { get; set; }
            public string Callsign { get; set; }
            public string PhoneNumber { get; set; }
            public string Expiration { get; set; }
            public string DOB { get; set; }
            public string MemberID { get; set; }
            public string Role { get; set; }
            public string Address { get; set; }
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string Comment { get; set; }
            public string UserID { get; set; }
            public Image Photo { get; set; }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e) // new user
        {
            var userForum = new userCreation.userCreation();
            if (userForum.ShowDialog() == DialogResult.OK)
            {
                string callsign = userForum.Callsign;
                string name = userForum.NameOfUser;

                // Create the User
                TreeNode selectedNode = clubUserViewer.SelectedNode;

                if (selectedNode != null
                    && selectedNode.Level == 0)
                {
                    TreeNode newNode = selectedNode.Nodes.Add(callsign);
                    SetNodeIcons(newNode);
                    newNode.Tag = new UserData { Name = name, Callsign = callsign };
                }
                else
                {
                    MessageBox.Show("Please select the club you would like to create a user in, then try again.");

                }
            }
        }


        private void newClub(object sender, EventArgs e)
        {
            var userForum = new clubCreation();
            if (userForum.ShowDialog() == DialogResult.OK)
            {
                string name = userForum.clubNamePublic;

                // Create the Club
                TreeNode newNode = clubUserViewer.Nodes.Add(name);
                SetNodeIcons(newNode);
            }
        }

        private void editUser(object sender, EventArgs e)
        {
            var usrEdit = new userEditor();
            if (usrEdit.ShowDialog() == DialogResult.OK)
            {
                clubUserViewer.SelectedNode.Tag = new UserData
                {
                    Name = usrEdit.NamePublic, //
                    PhoneNumber = usrEdit.PhoneNumPublic, // 
                    Address = usrEdit.UserAddressPublic, //
                    DOB = usrEdit.DOBPublic, //
                    Expiration = usrEdit.ExpirationDatePublic, //
                    MemberID = usrEdit.MemberIDPublic, //
                    Role = usrEdit.UserRolePublic, //
                    Line1 = usrEdit.Line1Public, // 
                    Line2 = usrEdit.Line2Public, //
                    Photo = usrEdit.ImagePublic //

                };

                if (clubUserViewer.SelectedNode.Tag is UserData user)
                {
                    groupBox.Text = $"{user.Callsign}";
                    pictureBox1.Image = user.Photo;
                    labelName.Text = $"{user.Name}";
                    labelPhone.Text = $"{user.PhoneNumber}";
                    addressLabel.Text = $"{user.Address}";
                    dobLabel.Text = $"{user.DOB}";
                    expiration.Text = $"{user.Expiration}";
                    IDLabel.Text = $"ID: {user.MemberID}";
                    roleLabel.Text = $"{user.Role}";
                    line1label.Text = $"{user.Line1}";
                    line2label.Text = $"{user.Line2}";
                }
                groupBox.Visible = true;
            }
        }

        private void updateGroupBox(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is UserData user)
            {
                groupBox.Text = $"{user.Callsign}";
                pictureBox1.Image = user.Photo;
                labelName.Text = $"{user.Name}";
                labelPhone.Text = $"{user.PhoneNumber}";
                addressLabel.Text = $"{user.Address}";
                dobLabel.Text = $"{user.DOB}";
                expiration.Text = $"{user.Expiration}";
                IDLabel.Text = $"ID: {user.MemberID}";
                roleLabel.Text = $"{user.Role}";
                line1label.Text = $"{user.Line1}";
                line2label.Text = $"{user.Line2}";
            }
            else
            {
                labelName.Text = "(none)";
                labelPhone.Text = "(none)";
            }
            groupBox.Visible = true;
        }

        private void deleteSelected(object sender, EventArgs e)
        {
            clubUserViewer.SelectedNode.Remove();
        }
    }
}
