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
      this.lblPlayersNumber = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cmbMemberShips = new System.Windows.Forms.ComboBox();
      this.txbLastName = new System.Windows.Forms.TextBox();
      this.txbPhone = new System.Windows.Forms.TextBox();
      this.txbFirstName = new System.Windows.Forms.TextBox();
      this.lblPlayerID = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btnSave = new Pool_Club.Controls.ctrlExpertBtn();
      this.btnCancel = new Pool_Club.Controls.ctrlExpertBtn();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelDown.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.Black;
      this.lblTitle.Location = new System.Drawing.Point(294, 128);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(94, 25);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Add New";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Pool_Club.Properties.Resources.Players;
      this.pictureBox1.Location = new System.Drawing.Point(253, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(172, 109);
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
      this.panelDown.Size = new System.Drawing.Size(674, 160);
      this.panelDown.TabIndex = 4;
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.Black;
      this.lblPlayersNumber.Location = new System.Drawing.Point(26, 144);
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
      this.label2.Location = new System.Drawing.Point(23, 95);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "First Name :";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.groupBox1.Controls.Add(this.cmbMemberShips);
      this.groupBox1.Controls.Add(this.txbLastName);
      this.groupBox1.Controls.Add(this.txbPhone);
      this.groupBox1.Controls.Add(this.txbFirstName);
      this.groupBox1.Controls.Add(this.lblPlayerID);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.lblPlayersNumber);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Black;
      this.groupBox1.Location = new System.Drawing.Point(0, 160);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(674, 242);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Player info";
      // 
      // cmbMemberShips
      // 
      this.cmbMemberShips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMemberShips.FormattingEnabled = true;
      this.cmbMemberShips.Location = new System.Drawing.Point(388, 125);
      this.cmbMemberShips.Name = "cmbMemberShips";
      this.cmbMemberShips.Size = new System.Drawing.Size(219, 28);
      this.cmbMemberShips.TabIndex = 4;
      // 
      // txbLastName
      // 
      this.txbLastName.Location = new System.Drawing.Point(148, 143);
      this.txbLastName.Name = "txbLastName";
      this.txbLastName.Size = new System.Drawing.Size(169, 27);
      this.txbLastName.TabIndex = 2;
      // 
      // txbPhone
      // 
      this.txbPhone.Location = new System.Drawing.Point(148, 188);
      this.txbPhone.Name = "txbPhone";
      this.txbPhone.Size = new System.Drawing.Size(169, 27);
      this.txbPhone.TabIndex = 3;
      // 
      // txbFirstName
      // 
      this.txbFirstName.Location = new System.Drawing.Point(148, 94);
      this.txbFirstName.Name = "txbFirstName";
      this.txbFirstName.Size = new System.Drawing.Size(169, 27);
      this.txbFirstName.TabIndex = 1;
      // 
      // lblPlayerID
      // 
      this.lblPlayerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayerID.AutoSize = true;
      this.lblPlayerID.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerID.ForeColor = System.Drawing.Color.Black;
      this.lblPlayerID.Location = new System.Drawing.Point(143, 53);
      this.lblPlayerID.Name = "lblPlayerID";
      this.lblPlayerID.Size = new System.Drawing.Size(36, 25);
      this.lblPlayerID.TabIndex = 3;
      this.lblPlayerID.Text = "???";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(43, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "PlayerID :";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Black;
      this.label4.Location = new System.Drawing.Point(403, 95);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(189, 25);
      this.label4.TabIndex = 6;
      this.label4.Text = "Member Ship Type :";
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Black;
      this.label6.Location = new System.Drawing.Point(61, 189);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(79, 25);
      this.label6.TabIndex = 4;
      this.label6.Text = "Phone :";
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
      this.btnSave.Location = new System.Drawing.Point(384, 406);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(132, 45);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.White;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
      this.btnCancel.Location = new System.Drawing.Point(532, 406);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(132, 45);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.TextColor = System.Drawing.Color.White;
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmAddUpdatePlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ClientSize = new System.Drawing.Size(674, 458);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
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
  }
}