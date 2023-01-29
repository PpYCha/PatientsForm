namespace PatientsForm
{
    partial class PatientProfileForm
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
            this.components = new System.ComponentModel.Container();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.cb_CivilStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cb_Sex = new ReaLTaiizor.Controls.MaterialComboBox();
            this.tb_Age = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_ContactNumber = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_LastName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_MiddleName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_FirstName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_Address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.dataGridView_examination = new System.Windows.Forms.DataGridView();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examinationTreatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_prescription = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            this.prescriptionIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInformationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_examination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationTreatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prescription)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.dtp_Birthday);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.cb_CivilStatus);
            this.materialCard1.Controls.Add(this.cb_Sex);
            this.materialCard1.Controls.Add(this.tb_Age);
            this.materialCard1.Controls.Add(this.tb_ContactNumber);
            this.materialCard1.Controls.Add(this.tb_LastName);
            this.materialCard1.Controls.Add(this.tb_MiddleName);
            this.materialCard1.Controls.Add(this.tb_FirstName);
            this.materialCard1.Controls.Add(this.tb_Address);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(785, 338);
            this.materialCard1.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 177);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Birthdate";
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Location = new System.Drawing.Point(18, 199);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(249, 23);
            this.dtp_Birthday.TabIndex = 14;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(18, 14);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(293, 41);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Patient Information";
            // 
            // cb_CivilStatus
            // 
            this.cb_CivilStatus.AutoResize = false;
            this.cb_CivilStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_CivilStatus.Depth = 0;
            this.cb_CivilStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_CivilStatus.DropDownHeight = 174;
            this.cb_CivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CivilStatus.DropDownWidth = 121;
            this.cb_CivilStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_CivilStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_CivilStatus.FormattingEnabled = true;
            this.cb_CivilStatus.Hint = "Civil Status";
            this.cb_CivilStatus.IntegralHeight = false;
            this.cb_CivilStatus.ItemHeight = 43;
            this.cb_CivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Common Law Partner"});
            this.cb_CivilStatus.Location = new System.Drawing.Point(273, 228);
            this.cb_CivilStatus.MaxDropDownItems = 4;
            this.cb_CivilStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_CivilStatus.Name = "cb_CivilStatus";
            this.cb_CivilStatus.Size = new System.Drawing.Size(250, 49);
            this.cb_CivilStatus.StartIndex = 0;
            this.cb_CivilStatus.TabIndex = 10;
            this.cb_CivilStatus.UseAccent = false;
            // 
            // cb_Sex
            // 
            this.cb_Sex.AutoResize = false;
            this.cb_Sex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Sex.Depth = 0;
            this.cb_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Sex.DropDownHeight = 174;
            this.cb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sex.DropDownWidth = 121;
            this.cb_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_Sex.FormattingEnabled = true;
            this.cb_Sex.Hint = "Sex";
            this.cb_Sex.IntegralHeight = false;
            this.cb_Sex.ItemHeight = 43;
            this.cb_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Sex.Location = new System.Drawing.Point(17, 228);
            this.cb_Sex.MaxDropDownItems = 4;
            this.cb_Sex.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(250, 49);
            this.cb_Sex.StartIndex = 0;
            this.cb_Sex.TabIndex = 9;
            this.cb_Sex.UseAccent = false;
            // 
            // tb_Age
            // 
            this.tb_Age.AnimateReadOnly = false;
            this.tb_Age.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_Age.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_Age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_Age.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_Age.Depth = 0;
            this.tb_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Age.HideSelection = true;
            this.tb_Age.Hint = "Age";
            this.tb_Age.LeadingIcon = null;
            this.tb_Age.Location = new System.Drawing.Point(273, 174);
            this.tb_Age.MaxLength = 32767;
            this.tb_Age.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.PasswordChar = '\0';
            this.tb_Age.PrefixSuffixText = null;
            this.tb_Age.ReadOnly = false;
            this.tb_Age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Age.SelectedText = "";
            this.tb_Age.SelectionLength = 0;
            this.tb_Age.SelectionStart = 0;
            this.tb_Age.ShortcutsEnabled = true;
            this.tb_Age.Size = new System.Drawing.Size(250, 48);
            this.tb_Age.TabIndex = 7;
            this.tb_Age.TabStop = false;
            this.tb_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Age.TrailingIcon = null;
            this.tb_Age.UseAccent = false;
            this.tb_Age.UseSystemPasswordChar = false;
            // 
            // tb_ContactNumber
            // 
            this.tb_ContactNumber.AnimateReadOnly = false;
            this.tb_ContactNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ContactNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ContactNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_ContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ContactNumber.Depth = 0;
            this.tb_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ContactNumber.HideSelection = true;
            this.tb_ContactNumber.Hint = "Contact Number";
            this.tb_ContactNumber.LeadingIcon = null;
            this.tb_ContactNumber.Location = new System.Drawing.Point(529, 120);
            this.tb_ContactNumber.MaxLength = 32767;
            this.tb_ContactNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_ContactNumber.Name = "tb_ContactNumber";
            this.tb_ContactNumber.PasswordChar = '\0';
            this.tb_ContactNumber.PrefixSuffixText = null;
            this.tb_ContactNumber.ReadOnly = false;
            this.tb_ContactNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_ContactNumber.SelectedText = "";
            this.tb_ContactNumber.SelectionLength = 0;
            this.tb_ContactNumber.SelectionStart = 0;
            this.tb_ContactNumber.ShortcutsEnabled = true;
            this.tb_ContactNumber.Size = new System.Drawing.Size(250, 48);
            this.tb_ContactNumber.TabIndex = 6;
            this.tb_ContactNumber.TabStop = false;
            this.tb_ContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ContactNumber.TrailingIcon = null;
            this.tb_ContactNumber.UseAccent = false;
            this.tb_ContactNumber.UseSystemPasswordChar = false;
            // 
            // tb_LastName
            // 
            this.tb_LastName.AnimateReadOnly = false;
            this.tb_LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_LastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_LastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_LastName.Depth = 0;
            this.tb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_LastName.HideSelection = true;
            this.tb_LastName.Hint = "Last Name";
            this.tb_LastName.LeadingIcon = null;
            this.tb_LastName.Location = new System.Drawing.Point(529, 66);
            this.tb_LastName.MaxLength = 32767;
            this.tb_LastName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.PasswordChar = '\0';
            this.tb_LastName.PrefixSuffixText = null;
            this.tb_LastName.ReadOnly = false;
            this.tb_LastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_LastName.SelectedText = "";
            this.tb_LastName.SelectionLength = 0;
            this.tb_LastName.SelectionStart = 0;
            this.tb_LastName.ShortcutsEnabled = true;
            this.tb_LastName.Size = new System.Drawing.Size(250, 48);
            this.tb_LastName.TabIndex = 4;
            this.tb_LastName.TabStop = false;
            this.tb_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_LastName.TrailingIcon = null;
            this.tb_LastName.UseAccent = false;
            this.tb_LastName.UseSystemPasswordChar = false;
            // 
            // tb_MiddleName
            // 
            this.tb_MiddleName.AnimateReadOnly = false;
            this.tb_MiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_MiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_MiddleName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_MiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_MiddleName.Depth = 0;
            this.tb_MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_MiddleName.HideSelection = true;
            this.tb_MiddleName.Hint = "Middle Name";
            this.tb_MiddleName.LeadingIcon = null;
            this.tb_MiddleName.Location = new System.Drawing.Point(273, 66);
            this.tb_MiddleName.MaxLength = 32767;
            this.tb_MiddleName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_MiddleName.Name = "tb_MiddleName";
            this.tb_MiddleName.PasswordChar = '\0';
            this.tb_MiddleName.PrefixSuffixText = null;
            this.tb_MiddleName.ReadOnly = false;
            this.tb_MiddleName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_MiddleName.SelectedText = "";
            this.tb_MiddleName.SelectionLength = 0;
            this.tb_MiddleName.SelectionStart = 0;
            this.tb_MiddleName.ShortcutsEnabled = true;
            this.tb_MiddleName.Size = new System.Drawing.Size(250, 48);
            this.tb_MiddleName.TabIndex = 3;
            this.tb_MiddleName.TabStop = false;
            this.tb_MiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_MiddleName.TrailingIcon = null;
            this.tb_MiddleName.UseAccent = false;
            this.tb_MiddleName.UseSystemPasswordChar = false;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.AnimateReadOnly = false;
            this.tb_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_FirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_FirstName.Depth = 0;
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_FirstName.HideSelection = true;
            this.tb_FirstName.Hint = "First Name";
            this.tb_FirstName.LeadingIcon = null;
            this.tb_FirstName.Location = new System.Drawing.Point(17, 66);
            this.tb_FirstName.MaxLength = 32767;
            this.tb_FirstName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.PasswordChar = '\0';
            this.tb_FirstName.PrefixSuffixText = null;
            this.tb_FirstName.ReadOnly = false;
            this.tb_FirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_FirstName.SelectedText = "";
            this.tb_FirstName.SelectionLength = 0;
            this.tb_FirstName.SelectionStart = 0;
            this.tb_FirstName.ShortcutsEnabled = true;
            this.tb_FirstName.Size = new System.Drawing.Size(250, 48);
            this.tb_FirstName.TabIndex = 2;
            this.tb_FirstName.TabStop = false;
            this.tb_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_FirstName.TrailingIcon = null;
            this.tb_FirstName.UseAccent = false;
            this.tb_FirstName.UseSystemPasswordChar = false;
            // 
            // tb_Address
            // 
            this.tb_Address.AnimateReadOnly = false;
            this.tb_Address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_Address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_Address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_Address.Depth = 0;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Address.HideSelection = true;
            this.tb_Address.Hint = "Address";
            this.tb_Address.LeadingIcon = null;
            this.tb_Address.Location = new System.Drawing.Point(17, 120);
            this.tb_Address.MaxLength = 32767;
            this.tb_Address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.PasswordChar = '\0';
            this.tb_Address.PrefixSuffixText = null;
            this.tb_Address.ReadOnly = false;
            this.tb_Address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Address.SelectedText = "";
            this.tb_Address.SelectionLength = 0;
            this.tb_Address.SelectionStart = 0;
            this.tb_Address.ShortcutsEnabled = true;
            this.tb_Address.Size = new System.Drawing.Size(506, 48);
            this.tb_Address.TabIndex = 1;
            this.tb_Address.TabStop = false;
            this.tb_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Address.TrailingIcon = null;
            this.tb_Address.UseAccent = false;
            this.tb_Address.UseSystemPasswordChar = false;
            // 
            // dataGridView_examination
            // 
            this.dataGridView_examination.AllowUserToAddRows = false;
            this.dataGridView_examination.AllowUserToDeleteRows = false;
            this.dataGridView_examination.AllowUserToResizeColumns = false;
            this.dataGridView_examination.AllowUserToResizeRows = false;
            this.dataGridView_examination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_examination.AutoGenerateColumns = false;
            this.dataGridView_examination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_examination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_examination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionIdDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.patientIdDataGridViewTextBoxColumn1,
            this.patientInformationDataGridViewTextBoxColumn1});
            this.dataGridView_examination.DataSource = this.prescriptionBindingSource;
            this.dataGridView_examination.Location = new System.Drawing.Point(4, 474);
            this.dataGridView_examination.Name = "dataGridView_examination";
            this.dataGridView_examination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_examination.Size = new System.Drawing.Size(1521, 176);
            this.dataGridView_examination.TabIndex = 4;
            this.dataGridView_examination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataSource = typeof(PatientsForm.Models.Prescription);
            // 
            // dataGridView_prescription
            // 
            this.dataGridView_prescription.AllowUserToAddRows = false;
            this.dataGridView_prescription.AllowUserToDeleteRows = false;
            this.dataGridView_prescription.AllowUserToResizeColumns = false;
            this.dataGridView_prescription.AllowUserToResizeRows = false;
            this.dataGridView_prescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_prescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prescription.Location = new System.Drawing.Point(819, 122);
            this.dataGridView_prescription.Name = "dataGridView_prescription";
            this.dataGridView_prescription.RowTemplate.Height = 25;
            this.dataGridView_prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_prescription.Size = new System.Drawing.Size(686, 294);
            this.dataGridView_prescription.TabIndex = 5;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(1073, 425);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(205, 35);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Print Medicial Certificate";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(1286, 425);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(221, 35);
            this.materialButton2.TabIndex = 15;
            this.materialButton2.Text = "Print Medical Health Record";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(17, 430);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(420, 41);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Examination and Treatment";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(819, 78);
            this.materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(195, 41);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "Prescrtiption";
            // 
            // prescriptionIdDataGridViewTextBoxColumn1
            // 
            this.prescriptionIdDataGridViewTextBoxColumn1.DataPropertyName = "PrescriptionId";
            this.prescriptionIdDataGridViewTextBoxColumn1.HeaderText = "PrescriptionId";
            this.prescriptionIdDataGridViewTextBoxColumn1.Name = "prescriptionIdDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medecine";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medecine";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Instructions";
            this.dataGridViewTextBoxColumn6.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Clinician";
            this.dataGridViewTextBoxColumn7.HeaderText = "Clinician";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn8.HeaderText = "Diagnosis";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // patientIdDataGridViewTextBoxColumn1
            // 
            this.patientIdDataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn1.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn1.Name = "patientIdDataGridViewTextBoxColumn1";
            this.patientIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientInformationDataGridViewTextBoxColumn1
            // 
            this.patientInformationDataGridViewTextBoxColumn1.DataPropertyName = "PatientInformation";
            this.patientInformationDataGridViewTextBoxColumn1.HeaderText = "PatientInformation";
            this.patientInformationDataGridViewTextBoxColumn1.Name = "patientInformationDataGridViewTextBoxColumn1";
            // 
            // PatientProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 653);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.dataGridView_prescription);
            this.Controls.Add(this.dataGridView_examination);
            this.Controls.Add(this.materialCard1);
            this.Name = "PatientProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientProfileForm_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_examination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationTreatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox cb_CivilStatus;
        private ReaLTaiizor.Controls.MaterialComboBox cb_Sex;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Age;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_ContactNumber;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_LastName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_MiddleName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_FirstName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Address;
        private System.Windows.Forms.DataGridView dataGridView_examination;
        private System.Windows.Forms.BindingSource examinationTreatmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodPressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heartRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fastingBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smokingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn illicitDrugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcoholDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientInformationDataGridViewTextBoxColumn1;
    }
}