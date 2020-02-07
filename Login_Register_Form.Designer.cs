namespace CSharp_Manage_Contact
{
    partial class Login_Register_Form
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

        #region

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Register_Form));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_GoToLogin = new System.Windows.Forms.Label();
            this.label_GoToRegister = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.label_PasswordRegister = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Picture = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Signin = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.textBox_PasswordRegister = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_UsernameRes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.button_Minimize);
            this.panel4.Controls.Add(this.button_Close);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 593);
            this.panel4.TabIndex = 0;
            // 
            // button_Minimize
            // 
            this.button_Minimize.BackColor = System.Drawing.Color.Honeydew;
            this.button_Minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_Minimize.Image")));
            this.button_Minimize.Location = new System.Drawing.Point(229, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(40, 40);
            this.button_Minimize.TabIndex = 1;
            this.button_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Honeydew;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(276, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.label_GoToLogin);
            this.panel5.Controls.Add(this.label_GoToRegister);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label_Password);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label_);
            this.panel5.Controls.Add(this.label_PasswordRegister);
            this.panel5.Controls.Add(this.label_FirstName);
            this.panel5.Controls.Add(this.label_LastName);
            this.panel5.Controls.Add(this.label_Picture);
            this.panel5.Controls.Add(this.label_Username);
            this.panel5.Controls.Add(this.button_Search);
            this.panel5.Controls.Add(this.button_Signin);
            this.panel5.Controls.Add(this.button_SignUp);
            this.panel5.Controls.Add(this.pictureBox_ProfilePicture);
            this.panel5.Controls.Add(this.textBox_PasswordRegister);
            this.panel5.Controls.Add(this.textBox_LastName);
            this.panel5.Controls.Add(this.textBox_Username);
            this.panel5.Controls.Add(this.textBox_Password);
            this.panel5.Controls.Add(this.textBox_FirstName);
            this.panel5.Controls.Add(this.textBox_UsernameRes);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(742, 553);
            this.panel5.TabIndex = 0;
            // 
            // label_GoToLogin
            // 
            this.label_GoToLogin.AutoSize = true;
            this.label_GoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_GoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoToLogin.Location = new System.Drawing.Point(409, 503);
            this.label_GoToLogin.Name = "label_GoToLogin";
            this.label_GoToLogin.Size = new System.Drawing.Size(194, 16);
            this.label_GoToLogin.TabIndex = 20;
            this.label_GoToLogin.Text = "<<Have an Account Yet?Sign in";
            this.label_GoToLogin.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label_GoToRegister
            // 
            this.label_GoToRegister.AutoSize = true;
            this.label_GoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_GoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoToRegister.Location = new System.Drawing.Point(33, 503);
            this.label_GoToRegister.Name = "label_GoToRegister";
            this.label_GoToRegister.Size = new System.Drawing.Size(236, 16);
            this.label_GoToRegister.TabIndex = 19;
            this.label_GoToRegister.Text = "Don\'t Have an Account Yet? Sign up>>";
            this.label_GoToRegister.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(338, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 29);
            this.label18.TabIndex = 18;
            this.label18.Text = "Create new account";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Password.Location = new System.Drawing.Point(13, 124);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 24);
            this.label_Password.TabIndex = 17;
            this.label_Password.Text = "Password:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(45, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 29);
            this.label16.TabIndex = 16;
            this.label16.Text = "Account Login";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_.Location = new System.Drawing.Point(339, 164);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(102, 24);
            this.label_.TabIndex = 15;
            this.label_.Text = "Username:";
            // 
            // label_PasswordRegister
            // 
            this.label_PasswordRegister.AutoSize = true;
            this.label_PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PasswordRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_PasswordRegister.Location = new System.Drawing.Point(339, 207);
            this.label_PasswordRegister.Name = "label_PasswordRegister";
            this.label_PasswordRegister.Size = new System.Drawing.Size(102, 24);
            this.label_PasswordRegister.TabIndex = 14;
            this.label_PasswordRegister.Text = "Password: ";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_FirstName.Location = new System.Drawing.Point(335, 76);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(106, 24);
            this.label_FirstName.TabIndex = 13;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_LastName.Location = new System.Drawing.Point(337, 124);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(104, 24);
            this.label_LastName.TabIndex = 12;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_Picture
            // 
            this.label_Picture.AutoSize = true;
            this.label_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Picture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Picture.Location = new System.Drawing.Point(368, 247);
            this.label_Picture.Name = "label_Picture";
            this.label_Picture.Size = new System.Drawing.Size(73, 24);
            this.label_Picture.TabIndex = 11;
            this.label_Picture.Text = "Picture:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Username.Location = new System.Drawing.Point(13, 77);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(107, 24);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username: ";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(597, 247);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(24, 87);
            this.button_Search.TabIndex = 9;
            this.button_Search.Text = "//";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // button_Signin
            // 
            this.button_Signin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Signin.ForeColor = System.Drawing.Color.White;
            this.button_Signin.Location = new System.Drawing.Point(66, 190);
            this.button_Signin.Name = "button_Signin";
            this.button_Signin.Size = new System.Drawing.Size(168, 55);
            this.button_Signin.TabIndex = 8;
            this.button_Signin.Text = "Login";
            this.button_Signin.UseVisualStyleBackColor = false;
            this.button_Signin.Click += new System.EventHandler(this.Button_Signin_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_SignUp.ForeColor = System.Drawing.Color.White;
            this.button_SignUp.Location = new System.Drawing.Point(419, 375);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(184, 53);
            this.button_SignUp.TabIndex = 7;
            this.button_SignUp.Text = "Register";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.Button_SignUp_Click);
            // 
            // pictureBox_ProfilePicture
            // 
            this.pictureBox_ProfilePicture.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(447, 247);
            this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
            this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(144, 87);
            this.pictureBox_ProfilePicture.TabIndex = 6;
            this.pictureBox_ProfilePicture.TabStop = false;
            // 
            // textBox_PasswordRegister
            // 
            this.textBox_PasswordRegister.BackColor = System.Drawing.Color.Gray;
            this.textBox_PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordRegister.ForeColor = System.Drawing.Color.White;
            this.textBox_PasswordRegister.Location = new System.Drawing.Point(447, 204);
            this.textBox_PasswordRegister.Name = "textBox_PasswordRegister";
            this.textBox_PasswordRegister.Size = new System.Drawing.Size(174, 26);
            this.textBox_PasswordRegister.TabIndex = 5;
            this.textBox_PasswordRegister.UseSystemPasswordChar = true;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.BackColor = System.Drawing.Color.Gray;
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.ForeColor = System.Drawing.Color.White;
            this.textBox_LastName.Location = new System.Drawing.Point(447, 122);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(174, 26);
            this.textBox_LastName.TabIndex = 4;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.Gray;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.ForeColor = System.Drawing.Color.White;
            this.textBox_Username.Location = new System.Drawing.Point(126, 79);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(167, 26);
            this.textBox_Username.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.Gray;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(126, 122);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(167, 26);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.BackColor = System.Drawing.Color.Gray;
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.ForeColor = System.Drawing.Color.White;
            this.textBox_FirstName.Location = new System.Drawing.Point(447, 79);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(174, 26);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // textBox_UsernameRes
            // 
            this.textBox_UsernameRes.BackColor = System.Drawing.Color.Gray;
            this.textBox_UsernameRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UsernameRes.ForeColor = System.Drawing.Color.White;
            this.textBox_UsernameRes.Location = new System.Drawing.Point(447, 164);
            this.textBox_UsernameRes.Name = "textBox_UsernameRes";
            this.textBox_UsernameRes.Size = new System.Drawing.Size(174, 26);
            this.textBox_UsernameRes.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Login_Register_Form
            // 
            this.ClientSize = new System.Drawing.Size(765, 593);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Register_Form";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label_PasswordRegister;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Picture;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Signin;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.PictureBox pictureBox_ProfilePicture;
        private System.Windows.Forms.TextBox textBox_PasswordRegister;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_UsernameRes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_GoToRegister;
        private System.Windows.Forms.Label label_GoToLogin;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}