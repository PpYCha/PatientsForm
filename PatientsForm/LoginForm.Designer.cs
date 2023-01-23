namespace PatientsForm
{
    partial class LoginForm
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
            this.tb_loginUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_Login = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_loginPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_Register = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tb_loginUsername
            // 
            this.tb_loginUsername.AnimateReadOnly = false;
            this.tb_loginUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_loginUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_loginUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_loginUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_loginUsername.Depth = 0;
            this.tb_loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_loginUsername.HideSelection = true;
            this.tb_loginUsername.Hint = "Username";
            this.tb_loginUsername.LeadingIcon = null;
            this.tb_loginUsername.Location = new System.Drawing.Point(74, 88);
            this.tb_loginUsername.MaxLength = 32767;
            this.tb_loginUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_loginUsername.Name = "tb_loginUsername";
            this.tb_loginUsername.PasswordChar = '\0';
            this.tb_loginUsername.PrefixSuffixText = null;
            this.tb_loginUsername.ReadOnly = false;
            this.tb_loginUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_loginUsername.SelectedText = "";
            this.tb_loginUsername.SelectionLength = 0;
            this.tb_loginUsername.SelectionStart = 0;
            this.tb_loginUsername.ShortcutsEnabled = true;
            this.tb_loginUsername.Size = new System.Drawing.Size(332, 48);
            this.tb_loginUsername.TabIndex = 0;
            this.tb_loginUsername.TabStop = false;
            this.tb_loginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_loginUsername.TrailingIcon = null;
            this.tb_loginUsername.UseAccent = false;
            this.tb_loginUsername.UseSystemPasswordChar = false;
            // 
            // bt_Login
            // 
            this.bt_Login.AutoSize = false;
            this.bt_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Login.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Login.Depth = 0;
            this.bt_Login.HighEmphasis = true;
            this.bt_Login.Icon = null;
            this.bt_Login.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_Login.Location = new System.Drawing.Point(169, 232);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Login.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Login.Size = new System.Drawing.Size(152, 40);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "LOGIN";
            this.bt_Login.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Login.UseAccentColor = false;
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // tb_loginPassword
            // 
            this.tb_loginPassword.AnimateReadOnly = false;
            this.tb_loginPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_loginPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_loginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_loginPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_loginPassword.Depth = 0;
            this.tb_loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_loginPassword.HideSelection = true;
            this.tb_loginPassword.Hint = "Password";
            this.tb_loginPassword.LeadingIcon = null;
            this.tb_loginPassword.Location = new System.Drawing.Point(74, 163);
            this.tb_loginPassword.MaxLength = 32767;
            this.tb_loginPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_loginPassword.Name = "tb_loginPassword";
            this.tb_loginPassword.PasswordChar = '\0';
            this.tb_loginPassword.PrefixSuffixText = null;
            this.tb_loginPassword.ReadOnly = false;
            this.tb_loginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_loginPassword.SelectedText = "";
            this.tb_loginPassword.SelectionLength = 0;
            this.tb_loginPassword.SelectionStart = 0;
            this.tb_loginPassword.ShortcutsEnabled = true;
            this.tb_loginPassword.Size = new System.Drawing.Size(332, 48);
            this.tb_loginPassword.TabIndex = 4;
            this.tb_loginPassword.TabStop = false;
            this.tb_loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_loginPassword.TrailingIcon = null;
            this.tb_loginPassword.UseAccent = false;
            this.tb_loginPassword.UseSystemPasswordChar = false;
            // 
            // bt_Register
            // 
            this.bt_Register.AutoSize = false;
            this.bt_Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Register.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Register.Depth = 0;
            this.bt_Register.HighEmphasis = true;
            this.bt_Register.Icon = null;
            this.bt_Register.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_Register.Location = new System.Drawing.Point(169, 280);
            this.bt_Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Register.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Register.Size = new System.Drawing.Size(152, 40);
            this.bt_Register.TabIndex = 5;
            this.bt_Register.Text = "REGISTER";
            this.bt_Register.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Register.UseAccentColor = false;
            this.bt_Register.UseVisualStyleBackColor = true;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 359);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.tb_loginPassword);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_loginUsername);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_loginUsername;
        private ReaLTaiizor.Controls.MaterialButton bt_Login;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_loginPassword;
        private ReaLTaiizor.Controls.MaterialButton bt_Register;
    }
}