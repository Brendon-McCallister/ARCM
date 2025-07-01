namespace ARCCM
{
    partial class userEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phoneNum = new TextBox();
            expirationDate = new TextBox();
            name = new TextBox();
            textBox5 = new TextBox();
            dateOfBirth = new TextBox();
            button1 = new Button();
            label4 = new Label();
            memberID = new TextBox();
            Address = new TextBox();
            line1 = new TextBox();
            label5 = new Label();
            imageUpload = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            line2 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            label11 = new Label();
            userRole = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(110, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 48);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 77);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Membership Ends";
            // 
            // phoneNum
            // 
            phoneNum.Location = new Point(155, 45);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(158, 23);
            phoneNum.TabIndex = 3;
            // 
            // expirationDate
            // 
            expirationDate.Location = new Point(155, 74);
            expirationDate.Name = "expirationDate";
            expirationDate.Size = new Size(158, 23);
            expirationDate.TabIndex = 4;
            // 
            // name
            // 
            name.Location = new Point(155, 16);
            name.Name = "name";
            name.Size = new Size(158, 23);
            name.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(343, 27);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(329, 282);
            textBox5.TabIndex = 7;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(155, 103);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(158, 23);
            dateOfBirth.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(12, 326);
            button1.Name = "button1";
            button1.Size = new Size(507, 23);
            button1.TabIndex = 9;
            button1.Text = "Submit But Longer than usual";
            button1.UseVisualStyleBackColor = true;
            button1.Click += submit;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 106);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Date of Birth";
            // 
            // memberID
            // 
            memberID.Location = new Point(155, 132);
            memberID.Name = "memberID";
            memberID.Size = new Size(158, 23);
            memberID.TabIndex = 11;
            // 
            // Address
            // 
            Address.Location = new Point(155, 193);
            Address.Name = "Address";
            Address.Size = new Size(158, 23);
            Address.TabIndex = 13;
            // 
            // line1
            // 
            line1.Location = new Point(155, 222);
            line1.Name = "line1";
            line1.Size = new Size(158, 23);
            line1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 15;
            label5.Text = "Comments";
            // 
            // imageUpload
            // 
            imageUpload.Location = new Point(47, 286);
            imageUpload.Name = "imageUpload";
            imageUpload.Size = new Size(266, 23);
            imageUpload.TabIndex = 16;
            imageUpload.Text = "Upload Image";
            imageUpload.UseVisualStyleBackColor = true;
            imageUpload.Click += uploadImg;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 230);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 196);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 18;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 225);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 19;
            label8.Text = "Line 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(110, 254);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 20;
            label9.Text = "Line 2";
            // 
            // line2
            // 
            line2.Location = new Point(155, 251);
            line2.Name = "line2";
            line2.Size = new Size(158, 23);
            line2.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 135);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 22;
            label10.Text = "Member #";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(541, 326);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 23;
            button2.Text = "Delete User";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 168);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 24;
            label11.Text = "Role";
            // 
            // userRole
            // 
            userRole.Location = new Point(155, 165);
            userRole.Name = "userRole";
            userRole.Size = new Size(158, 23);
            userRole.TabIndex = 25;
            // 
            // userEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(userRole);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(line2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(imageUpload);
            Controls.Add(label5);
            Controls.Add(line1);
            Controls.Add(Address);
            Controls.Add(memberID);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dateOfBirth);
            Controls.Add(textBox5);
            Controls.Add(name);
            Controls.Add(expirationDate);
            Controls.Add(phoneNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "userEditor";
            Text = "Member Editor";
            Load += userEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox phoneNum;
        private TextBox expirationDate;
        private TextBox name;
        private TextBox textBox5;
        private TextBox dateOfBirth;
        private Button button1;
        private Label label4;
        private TextBox memberID;
        private TextBox Address;
        private TextBox line1;
        private Label label5;
        private Button imageUpload;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox line2;
        private Label label10;
        private Button button2;
        private Label label11;
        private TextBox userRole;
    }
}