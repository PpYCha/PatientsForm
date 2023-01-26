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
            this.bt_Exit = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_Register = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_Login = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_loginPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_loginUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Exit
            // 
            this.bt_Exit.AutoSize = false;
            this.bt_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Exit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Exit.Depth = 0;
            this.bt_Exit.HighEmphasis = true;
            this.bt_Exit.Icon = null;
            this.bt_Exit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_Exit.Location = new System.Drawing.Point(212, 318);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Exit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Exit.Size = new System.Drawing.Size(152, 40);
            this.bt_Exit.TabIndex = 15;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Exit.UseAccentColor = false;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
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
            this.bt_Register.Location = new System.Drawing.Point(212, 266);
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
            // bt_Login
            // 
            this.bt_Login.AutoSize = false;
            this.bt_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Login.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Login.Depth = 0;
            this.bt_Login.HighEmphasis = true;
            this.bt_Login.Icon = null;
            this.bt_Login.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_Login.Location = new System.Drawing.Point(212, 218);
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
            this.tb_loginPassword.Location = new System.Drawing.Point(128, 161);
            this.tb_loginPassword.MaxLength = 32767;
            this.tb_loginPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_loginPassword.Name = "tb_loginPassword";
            this.tb_loginPassword.PasswordChar = '●';
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
            this.tb_loginPassword.UseSystemPasswordChar = true;
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
            this.tb_loginUsername.Location = new System.Drawing.Point(128, 107);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(84, 45);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 41);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "LOGIN";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.bt_Exit);
            this.panel1.Controls.Add(this.bt_Register);
            this.panel1.Controls.Add(this.tb_loginUsername);
            this.panel1.Controls.Add(this.bt_Login);
            this.panel1.Controls.Add(this.tb_loginPassword);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 430);
            this.panel1.TabIndex = 16;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 547);
            this.Controls.Add(this.panel1);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton bt_Exit;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_loginUsername;
        private ReaLTaiizor.Controls.MaterialButton bt_Login;
        private ReaLTaiizor.Controls.MaterialButton bt_Register;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_loginPassword;
        private System.Windows.Forms.Panel panel1;
    }
}