namespace Pool_Club.Players
{
  partial class frmAddUpdatePlayer
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelDown = new System.Windows.Forms.Panel();
      this.cmbMemberShips = new System.Windows.Forms.ComboBox();
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.iconButton3 = new FontAwesome.Sharp.IconButton();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.btnCancel = new Pool_Club.Controls.ctrlExpertBtn();
      this.label4 = new System.Windows.Forms.Label();
      this.txbLastName = new System.Windows.Forms.TextBox();
      this.btnSave = new Pool_Club.Controls.ctrlExpertBtn();
      this.lblPlayerID = new System.Windows.Forms.Label();
      this.txbPhone = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txbFirstName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.iconButton5 = new FontAwesome.Sharp.IconButton();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelDown.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.lblTitle.Location = new System.Drawing.Point(136, 122);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(94, 25);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Add New";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Pool_Club.Properties.Resources.Players;
      this.pictureBox1.Location = new System.Drawing.Point(112, 14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(143, 96);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.panelDown.Controls.Add(this.pictureBox1);
      this.panelDown.Controls.Add(this.lblTitle);
      this.panelDown.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelDown.Location = new System.Drawing.Point(0, 0);
      this.panelDown.Name = "panelDown";
      this.panelDown.Size = new System.Drawing.Size(366, 160);
      this.panelDown.TabIndex = 4;
      // 
      // cmbMemberShips
      // 
      this.cmbMemberShips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMemberShips.FormattingEnabled = true;
      this.cmbMemberShips.Location = new System.Drawing.Point(77, 233);
      this.cmbMemberShips.Name = "cmbMemberShips";
      this.cmbMemberShips.Size = new System.Drawing.Size(219, 28);
      this.cmbMemberShips.TabIndex = 4;
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.Black;
      this.lblPlayersNumber.Location = new System.Drawing.Point(55, 117);
      this.lblPlayersNumber.Name = "lblPlayersNumber";
      this.lblPlayersNumber.Size = new System.Drawing.Size(114, 25);
      this.lblPlayersNumber.TabIndex = 1;
      this.lblPlayersNumber.Text = "Last Name :";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(52, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "First Name :";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.iconButton5);
      this.groupBox1.Controls.Add(this.iconButton3);
      this.groupBox1.Controls.Add(this.iconButton1);
      this.groupBox1.Controls.Add(this.cmbMemberShips);
      this.groupBox1.Controls.Add(this.btnCancel);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txbLastName);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.lblPlayerID);
      this.groupBox1.Controls.Add(this.txbPhone);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txbFirstName);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.lblPlayersNumber);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Black;
      this.groupBox1.Location = new System.Drawing.Point(0, 160);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(366, 354);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Player info";
      // 
      // iconButton3
      // 
      this.iconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.iconButton3.FlatAppearance.BorderSize = 0;
      this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
      this.iconButton3.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton3.IconSize = 35;
      this.iconButton3.Location = new System.Drawing.Point(14, 69);
      this.iconButton3.Name = "iconButton3";
      this.iconButton3.Size = new System.Drawing.Size(35, 27);
      this.iconButton3.TabIndex = 10;
      this.iconButton3.UseVisualStyleBackColor = true;
      // 
      // iconButton1
      // 
      this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Orcid;
      this.iconButton1.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 35;
      this.iconButton1.Location = new System.Drawing.Point(14, 27);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(35, 27);
      this.iconButton1.TabIndex = 8;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
      this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
      this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnCancel.BorderRadius = 6;
      this.btnCancel.BorderSize = 0;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(231, 305);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 42);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.TextColor = System.Drawing.Color.White;
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Black;
      this.label4.Location = new System.Drawing.Point(89, 203);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(189, 25);
      this.label4.TabIndex = 6;
      this.label4.Text = "Member Ship Type :";
      // 
      // txbLastName
      // 
      this.txbLastName.Location = new System.Drawing.Point(175, 118);
      this.txbLastName.Name = "txbLastName";
      this.txbLastName.Size = new System.Drawing.Size(169, 27);
      this.txbLastName.TabIndex = 2;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnSave.BorderRadius = 6;
      this.btnSave.BorderSize = 0;
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(101, 304);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 42);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.White;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lblPlayerID
      // 
      this.lblPlayerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayerID.AutoSize = true;
      this.lblPlayerID.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerID.ForeColor = System.Drawing.Color.Black;
      this.lblPlayerID.Location = new System.Drawing.Point(172, 26);
      this.lblPlayerID.Name = "lblPlayerID";
      this.lblPlayerID.Size = new System.Drawing.Size(36, 25);
      this.lblPlayerID.TabIndex = 3;
      this.lblPlayerID.Text = "???";
      // 
      // txbPhone
      // 
      this.txbPhone.Location = new System.Drawing.Point(175, 163);
      this.txbPhone.Name = "txbPhone";
      this.txbPhone.Size = new System.Drawing.Size(169, 27);
      this.txbPhone.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(72, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "PlayerID :";
      // 
      // txbFirstName
      // 
      this.txbFirstName.Location = new System.Drawing.Point(175, 69);
      this.txbFirstName.Name = "txbFirstName";
      this.txbFirstName.Size = new System.Drawing.Size(169, 27);
      this.txbFirstName.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Black;
      this.label6.Location = new System.Drawing.Point(90, 162);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(79, 25);
      this.label6.TabIndex = 4;
      this.label6.Text = "Phone :";
      // 
      // iconButton5
      // 
      this.iconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.iconButton5.FlatAppearance.BorderSize = 0;
      this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
      this.iconButton5.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton5.IconSize = 35;
      this.iconButton5.Location = new System.Drawing.Point(14, 234);
      this.iconButton5.Name = "iconButton5";
      this.iconButton5.Size = new System.Drawing.Size(35, 27);
      this.iconButton5.TabIndex = 12;
      this.iconButton5.UseVisualStyleBackColor = true;
      // 
      // frmAddUpdatePlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ClientSize = new System.Drawing.Size(366, 514);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panelDown);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddUpdatePlayer";
      this.Text = "Add New Player";
      this.Load += new System.EventHandler(this.frmAddUpdatePlayer_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panelDown;
    private System.Windows.Forms.Label lblPlayersNumber;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPlayerID;
    private System.Windows.Forms.TextBox txbLastName;
    private System.Windows.Forms.TextBox txbPhone;
    private System.Windows.Forms.TextBox txbFirstName;
    private System.Windows.Forms.ComboBox cmbMemberShips;
    private Controls.ctrlExpertBtn btnSave;
    private Controls.ctrlExpertBtn btnCancel;
    private FontAwesome.Sharp.IconButton iconButton1;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton iconButton5;
  }
}