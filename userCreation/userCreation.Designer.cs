namespace ARCCM.userCreation
{
    partial class userCreation
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
            submitUser = new Button();
            label1 = new Label();
            callsignSubmitted = new TextBox();
            nameOfUser = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // submitUser
            // 
            submitUser.Location = new Point(12, 209);
            submitUser.MaximumSize = new Size(80, 30);
            submitUser.MinimumSize = new Size(80, 30);
            submitUser.Name = "submitUser";
            submitUser.Size = new Size(80, 30);
            submitUser.TabIndex = 0;
            submitUser.Text = "Submit";
            submitUser.UseVisualStyleBackColor = true;
            submitUser.Click += submitClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 1;
            label1.Text = "Callsign";
            // 
            // callsignSubmitted
            // 
            callsignSubmitted.Location = new Point(74, 27);
            callsignSubmitted.Name = "callsignSubmitted";
            callsignSubmitted.Size = new Size(100, 23);
            callsignSubmitted.TabIndex = 2;
            // 
            // nameOfUser
            // 
            nameOfUser.Location = new Point(63, 66);
            nameOfUser.Name = "nameOfUser";
            nameOfUser.Size = new Size(111, 23);
            nameOfUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // userCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 251);
            Controls.Add(label2);
            Controls.Add(nameOfUser);
            Controls.Add(callsignSubmitted);
            Controls.Add(label1);
            Controls.Add(submitUser);
            MaximumSize = new Size(230, 290);
            MinimumSize = new Size(230, 290);
            Name = "userCreation";
            Load += userCreation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitUser;
        private Label label1;
        private TextBox callsignSubmitted;
        private TextBox nameOfUser;
        private Label label2;
    }
}