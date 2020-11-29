namespace Test_Client
{
    partial class Form_Main
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
            this.panel_Info = new System.Windows.Forms.Panel();
            this.panel_User = new System.Windows.Forms.Panel();
            this.label_UserName = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.panel_Test_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Test_Show = new System.Windows.Forms.Button();
            this.btn_Groups_Add = new System.Windows.Forms.Button();
            this.btn_Groups_Update = new System.Windows.Forms.Button();
            this.btn_GroupAddUser = new System.Windows.Forms.Button();
            this.btn_GroupShowUsers = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_User.SuspendLayout();
            this.panel_Test_SubMenu.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(186, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(705, 42);
            this.panel_Info.TabIndex = 1;
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.label_UserName);
            this.panel_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_User.Location = new System.Drawing.Point(0, 0);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(186, 100);
            this.panel_User.TabIndex = 1;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.Aqua;
            this.label_UserName.Location = new System.Drawing.Point(12, 31);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(116, 25);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "User name";
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.btn_Test.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Test.FlatAppearance.BorderSize = 0;
            this.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Test.Location = new System.Drawing.Point(0, 100);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Test.Size = new System.Drawing.Size(186, 33);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "Test";
            this.btn_Test.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // panel_Test_SubMenu
            // 
            this.panel_Test_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel_Test_SubMenu.Controls.Add(this.btn_GroupShowUsers);
            this.panel_Test_SubMenu.Controls.Add(this.btn_GroupAddUser);
            this.panel_Test_SubMenu.Controls.Add(this.btn_Groups_Update);
            this.panel_Test_SubMenu.Controls.Add(this.btn_Groups_Add);
            this.panel_Test_SubMenu.Controls.Add(this.btn_Test_Show);
            this.panel_Test_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Test_SubMenu.Location = new System.Drawing.Point(0, 133);
            this.panel_Test_SubMenu.Name = "panel_Test_SubMenu";
            this.panel_Test_SubMenu.Size = new System.Drawing.Size(186, 122);
            this.panel_Test_SubMenu.TabIndex = 6;
            // 
            // btn_Test_Show
            // 
            this.btn_Test_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Test_Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Test_Show.FlatAppearance.BorderSize = 0;
            this.btn_Test_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test_Show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Test_Show.Location = new System.Drawing.Point(0, 0);
            this.btn_Test_Show.Name = "btn_Test_Show";
            this.btn_Test_Show.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Test_Show.Size = new System.Drawing.Size(186, 23);
            this.btn_Test_Show.TabIndex = 0;
            this.btn_Test_Show.Text = "Show";
            this.btn_Test_Show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Test_Show.UseVisualStyleBackColor = false;
            this.btn_Test_Show.Click += new System.EventHandler(this.btn_Test_Show_Click);
            // 
            // btn_Groups_Add
            // 
            this.btn_Groups_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Groups_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groups_Add.FlatAppearance.BorderSize = 0;
            this.btn_Groups_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groups_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Groups_Add.Location = new System.Drawing.Point(0, 23);
            this.btn_Groups_Add.Name = "btn_Groups_Add";
            this.btn_Groups_Add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Groups_Add.Size = new System.Drawing.Size(186, 23);
            this.btn_Groups_Add.TabIndex = 1;
            this.btn_Groups_Add.Text = "Add";
            this.btn_Groups_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groups_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Groups_Update
            // 
            this.btn_Groups_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_Groups_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groups_Update.FlatAppearance.BorderSize = 0;
            this.btn_Groups_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groups_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Groups_Update.Location = new System.Drawing.Point(0, 46);
            this.btn_Groups_Update.Name = "btn_Groups_Update";
            this.btn_Groups_Update.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Groups_Update.Size = new System.Drawing.Size(186, 23);
            this.btn_Groups_Update.TabIndex = 2;
            this.btn_Groups_Update.Text = "Update";
            this.btn_Groups_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groups_Update.UseVisualStyleBackColor = false;
            // 
            // btn_GroupAddUser
            // 
            this.btn_GroupAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_GroupAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GroupAddUser.FlatAppearance.BorderSize = 0;
            this.btn_GroupAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupAddUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GroupAddUser.Location = new System.Drawing.Point(0, 69);
            this.btn_GroupAddUser.Name = "btn_GroupAddUser";
            this.btn_GroupAddUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_GroupAddUser.Size = new System.Drawing.Size(186, 23);
            this.btn_GroupAddUser.TabIndex = 3;
            this.btn_GroupAddUser.Text = "Add user";
            this.btn_GroupAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GroupAddUser.UseVisualStyleBackColor = false;
            // 
            // btn_GroupShowUsers
            // 
            this.btn_GroupShowUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btn_GroupShowUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GroupShowUsers.FlatAppearance.BorderSize = 0;
            this.btn_GroupShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupShowUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GroupShowUsers.Location = new System.Drawing.Point(0, 92);
            this.btn_GroupShowUsers.Name = "btn_GroupShowUsers";
            this.btn_GroupShowUsers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_GroupShowUsers.Size = new System.Drawing.Size(186, 23);
            this.btn_GroupShowUsers.TabIndex = 4;
            this.btn_GroupShowUsers.Text = "Show Users";
            this.btn_GroupShowUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GroupShowUsers.UseVisualStyleBackColor = false;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.panel_Menu.Controls.Add(this.panel_Test_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_Test);
            this.panel_Menu.Controls.Add(this.panel_User);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(186, 450);
            this.panel_Menu.TabIndex = 0;
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(186, 42);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(705, 408);
            this.panel_Main.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            this.panel_Test_SubMenu.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Panel panel_Test_SubMenu;
        private System.Windows.Forms.Button btn_GroupShowUsers;
        private System.Windows.Forms.Button btn_GroupAddUser;
        private System.Windows.Forms.Button btn_Groups_Update;
        private System.Windows.Forms.Button btn_Groups_Add;
        private System.Windows.Forms.Button btn_Test_Show;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Main;
    }
}