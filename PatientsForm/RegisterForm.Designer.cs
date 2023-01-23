namespace PatientsForm
{
    partial class RegisterForm
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
            this.cb_uRetypePassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_BackToLogin = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_RegisterUser = new ReaLTaiizor.Controls.MaterialButton();
            this.cb_Usertype = new ReaLTaiizor.Controls.MaterialComboBox();
            this.tb_uPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_uUserName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_uLastName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_uFirstName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cb_uRetypePassword
            // 
            this.cb_uRetypePassword.AnimateReadOnly = false;
            this.cb_uRetypePassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cb_uRetypePassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cb_uRetypePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_uRetypePassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cb_uRetypePassword.Depth = 0;
            this.cb_uRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_uRetypePassword.HideSelection = true;
            this.cb_uRetypePassword.Hint = "Retype Password";
            this.cb_uRetypePassword.LeadingIcon = null;
            this.cb_uRetypePassword.Location = new System.Drawing.Point(25, 292);
            this.cb_uRetypePassword.MaxLength = 32767;
            this.cb_uRetypePassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_uRetypePassword.Name = "cb_uRetypePassword";
            this.cb_uRetypePassword.PasswordChar = '●';
            this.cb_uRetypePassword.PrefixSuffixText = null;
            this.cb_uRetypePassword.ReadOnly = false;
            this.cb_uRetypePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_uRetypePassword.SelectedText = "";
            this.cb_uRetypePassword.SelectionLength = 0;
            this.cb_uRetypePassword.SelectionStart = 0;
            this.cb_uRetypePassword.ShortcutsEnabled = true;
            this.cb_uRetypePassword.Size = new System.Drawing.Size(506, 48);
            this.cb_uRetypePassword.TabIndex = 23;
            this.cb_uRetypePassword.TabStop = false;
            this.cb_uRetypePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cb_uRetypePassword.TrailingIcon = null;
            this.cb_uRetypePassword.UseAccent = false;
            this.cb_uRetypePassword.UseSystemPasswordChar = true;
            // 
            // bt_BackToLogin
            // 
            this.bt_BackToLogin.AutoSize = false;
            this.bt_BackToLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_BackToLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_BackToLogin.Depth = 0;
            this.bt_BackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BackToLogin.HighEmphasis = true;
            this.bt_BackToLogin.Icon = null;
            this.bt_BackToLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_BackToLogin.Location = new System.Drawing.Point(281, 406);
            this.bt_BackToLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_BackToLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_BackToLogin.Name = "bt_BackToLogin";
            this.bt_BackToLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_BackToLogin.Size = new System.Drawing.Size(250, 48);
            this.bt_BackToLogin.TabIndex = 22;
            this.bt_BackToLogin.Text = "BACK TO LOGIN";
            this.bt_BackToLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_BackToLogin.UseAccentColor = false;
            this.bt_BackToLogin.UseVisualStyleBackColor = true;
            this.bt_BackToLogin.Click += new System.EventHandler(this.bt_BackToLogin_Click);
            // 
            // bt_RegisterUser
            // 
            this.bt_RegisterUser.AutoSize = false;
            this.bt_RegisterUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_RegisterUser.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_RegisterUser.Depth = 0;
            this.bt_RegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RegisterUser.HighEmphasis = true;
            this.bt_RegisterUser.Icon = null;
            this.bt_RegisterUser.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_RegisterUser.Location = new System.Drawing.Point(25, 406);
            this.bt_RegisterUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_RegisterUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_RegisterUser.Name = "bt_RegisterUser";
            this.bt_RegisterUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_RegisterUser.Size = new System.Drawing.Size(250, 48);
            this.bt_RegisterUser.TabIndex = 21;
            this.bt_RegisterUser.Text = "REGISTER";
            this.bt_RegisterUser.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_RegisterUser.UseAccentColor = false;
            this.bt_RegisterUser.UseVisualStyleBackColor = true;
            this.bt_RegisterUser.Click += new System.EventHandler(this.bt_SaveUser_Click);
            // 
            // cb_Usertype
            // 
            this.cb_Usertype.AutoResize = false;
            this.cb_Usertype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Usertype.Depth = 0;
            this.cb_Usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Usertype.DropDownHeight = 174;
            this.cb_Usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usertype.DropDownWidth = 121;
            this.cb_Usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_Usertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_Usertype.FormattingEnabled = true;
            this.cb_Usertype.Hint = "User Type";
            this.cb_Usertype.IntegralHeight = false;
            this.cb_Usertype.ItemHeight = 43;
            this.cb_Usertype.Items.AddRange(new object[] {
            "Admin",
            "Encoder"});
            this.cb_Usertype.Location = new System.Drawing.Point(25, 348);
            this.cb_Usertype.MaxDropDownItems = 4;
            this.cb_Usertype.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_Usertype.Name = "cb_Usertype";
            this.cb_Usertype.Size = new System.Drawing.Size(506, 49);
            this.cb_Usertype.StartIndex = 0;
            this.cb_Usertype.TabIndex = 20;
            this.cb_Usertype.UseAccent = false;
            // 
            // tb_uPassword
            // 
            this.tb_uPassword.AnimateReadOnly = false;
            this.tb_uPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_uPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_uPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_uPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_uPassword.Depth = 0;
            this.tb_uPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_uPassword.HideSelection = true;
            this.tb_uPassword.Hint = "Password";
            this.tb_uPassword.LeadingIcon = null;
            this.tb_uPassword.Location = new System.Drawing.Point(25, 237);
            this.tb_uPassword.MaxLength = 32767;
            this.tb_uPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_uPassword.Name = "tb_uPassword";
            this.tb_uPassword.PasswordChar = '●';
            this.tb_uPassword.PrefixSuffixText = null;
            this.tb_uPassword.ReadOnly = false;
            this.tb_uPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_uPassword.SelectedText = "";
            this.tb_uPassword.SelectionLength = 0;
            this.tb_uPassword.SelectionStart = 0;
            this.tb_uPassword.ShortcutsEnabled = true;
            this.tb_uPassword.Size = new System.Drawing.Size(506, 48);
            this.tb_uPassword.TabIndex = 19;
            this.tb_uPassword.TabStop = false;
            this.tb_uPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_uPassword.TrailingIcon = null;
            this.tb_uPassword.UseAccent = false;
            this.tb_uPassword.UseSystemPasswordChar = true;
            // 
            // tb_uUserName
            // 
            this.tb_uUserName.AnimateReadOnly = false;
            this.tb_uUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_uUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_uUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_uUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_uUserName.Depth = 0;
            this.tb_uUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_uUserName.HideSelection = true;
            this.tb_uUserName.Hint = "Username";
            this.tb_uUserName.LeadingIcon = null;
            this.tb_uUserName.Location = new System.Drawing.Point(31, 183);
            this.tb_uUserName.MaxLength = 32767;
            this.tb_uUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_uUserName.Name = "tb_uUserName";
            this.tb_uUserName.PasswordChar = '\0';
            this.tb_uUserName.PrefixSuffixText = null;
            this.tb_uUserName.ReadOnly = false;
            this.tb_uUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_uUserName.SelectedText = "";
            this.tb_uUserName.SelectionLength = 0;
            this.tb_uUserName.SelectionStart = 0;
            this.tb_uUserName.ShortcutsEnabled = true;
            this.tb_uUserName.Size = new System.Drawing.Size(506, 48);
            this.tb_uUserName.TabIndex = 18;
            this.tb_uUserName.TabStop = false;
            this.tb_uUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_uUserName.TrailingIcon = null;
            this.tb_uUserName.UseAccent = false;
            this.tb_uUserName.UseSystemPasswordChar = false;
            // 
            // tb_uLastName
            // 
            this.tb_uLastName.AnimateReadOnly = false;
            this.tb_uLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_uLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_uLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_uLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_uLastName.Depth = 0;
            this.tb_uLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_uLastName.HideSelection = true;
            this.tb_uLastName.Hint = "Last Name";
            this.tb_uLastName.LeadingIcon = null;
            this.tb_uLastName.Location = new System.Drawing.Point(287, 129);
            this.tb_uLastName.MaxLength = 32767;
            this.tb_uLastName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_uLastName.Name = "tb_uLastName";
            this.tb_uLastName.PasswordChar = '\0';
            this.tb_uLastName.PrefixSuffixText = null;
            this.tb_uLastName.ReadOnly = false;
            this.tb_uLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_uLastName.SelectedText = "";
            this.tb_uLastName.SelectionLength = 0;
            this.tb_uLastName.SelectionStart = 0;
            this.tb_uLastName.ShortcutsEnabled = true;
            this.tb_uLastName.Size = new System.Drawing.Size(250, 48);
            this.tb_uLastName.TabIndex = 17;
            this.tb_uLastName.TabStop = false;
            this.tb_uLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_uLastName.TrailingIcon = null;
            this.tb_uLastName.UseAccent = false;
            this.tb_uLastName.UseSystemPasswordChar = false;
            // 
            // tb_uFirstName
            // 
            this.tb_uFirstName.AnimateReadOnly = false;
            this.tb_uFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_uFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_uFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_uFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_uFirstName.Depth = 0;
            this.tb_uFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_uFirstName.HideSelection = true;
            this.tb_uFirstName.Hint = "First Name";
            this.tb_uFirstName.LeadingIcon = null;
            this.tb_uFirstName.Location = new System.Drawing.Point(31, 129);
            this.tb_uFirstName.MaxLength = 32767;
            this.tb_uFirstName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_uFirstName.Name = "tb_uFirstName";
            this.tb_uFirstName.PasswordChar = '\0';
            this.tb_uFirstName.PrefixSuffixText = null;
            this.tb_uFirstName.ReadOnly = false;
            this.tb_uFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_uFirstName.SelectedText = "";
            this.tb_uFirstName.SelectionLength = 0;
            this.tb_uFirstName.SelectionStart = 0;
            this.tb_uFirstName.ShortcutsEnabled = true;
            this.tb_uFirstName.Size = new System.Drawing.Size(250, 48);
            this.tb_uFirstName.TabIndex = 16;
            this.tb_uFirstName.TabStop = false;
            this.tb_uFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_uFirstName.TrailingIcon = null;
            this.tb_uFirstName.UseAccent = false;
            this.tb_uFirstName.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(25, 74);
            this.materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(256, 41);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "User Information";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.cb_uRetypePassword);
            this.Controls.Add(this.bt_BackToLogin);
            this.Controls.Add(this.bt_RegisterUser);
            this.Controls.Add(this.cb_Usertype);
            this.Controls.Add(this.tb_uPassword);
            this.Controls.Add(this.tb_uUserName);
            this.Controls.Add(this.tb_uLastName);
            this.Controls.Add(this.tb_uFirstName);
            this.Controls.Add(this.materialLabel5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit cb_uRetypePassword;
        private ReaLTaiizor.Controls.MaterialButton bt_BackToLogin;
        private ReaLTaiizor.Controls.MaterialButton bt_RegisterUser;
        private ReaLTaiizor.Controls.MaterialComboBox cb_Usertype;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_uPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_uUserName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_uLastName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_uFirstName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
    }
}