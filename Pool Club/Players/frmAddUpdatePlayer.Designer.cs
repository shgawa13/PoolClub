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
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.ctrlExpertBtn1 = new Pool_Club.Controls.ctrlExpertBtn();
      this.btnCancel = new Pool_Club.Controls.ctrlExpertBtn();
      this.chbIsActive = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelDown.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chbIsActive)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblTitle.Location = new System.Drawing.Point(314, 130);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(94, 25);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Add New";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Pool_Club.Properties.Resources.Players;
      this.pictureBox1.Location = new System.Drawing.Point(274, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(172, 109);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // panelDown
      // 
      this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
      this.panelDown.Controls.Add(this.groupBox1);
      this.panelDown.Controls.Add(this.pictureBox1);
      this.panelDown.Controls.Add(this.lblTitle);
      this.panelDown.Location = new System.Drawing.Point(0, 0);
      this.panelDown.Name = "panelDown";
      this.panelDown.Size = new System.Drawing.Size(675, 400);
      this.panelDown.TabIndex = 4;
      // 
      // lblPlayersNumber
      // 
      this.lblPlayersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPlayersNumber.AutoSize = true;
      this.lblPlayersNumber.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayersNumber.ForeColor = System.Drawing.Color.GhostWhite;
      this.lblPlayersNumber.Location = new System.Drawing.Point(28, 134);
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
      this.label2.ForeColor = System.Drawing.Color.GhostWhite;
      this.label2.Location = new System.Drawing.Point(28, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "First Name :";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chbIsActive);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.lblPlayersNumber);
      this.groupBox1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
      this.groupBox1.Location = new System.Drawing.Point(12, 158);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(652, 232);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Player info";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.GhostWhite;
      this.label1.Location = new System.Drawing.Point(43, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "PlayerID :";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.GhostWhite;
      this.label3.Location = new System.Drawing.Point(143, 45);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 25);
      this.label3.TabIndex = 3;
      this.label3.Text = "???";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.GhostWhite;
      this.label4.Location = new System.Drawing.Point(403, 85);
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
      this.label6.ForeColor = System.Drawing.Color.GhostWhite;
      this.label6.Location = new System.Drawing.Point(73, 179);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 25);
      this.label6.TabIndex = 4;
      this.label6.Text = "Email :";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(148, 86);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(169, 27);
      this.textBox1.TabIndex = 8;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(148, 183);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(169, 27);
      this.textBox2.TabIndex = 9;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(148, 135);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(169, 27);
      this.textBox3.TabIndex = 10;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(388, 125);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(219, 28);
      this.comboBox1.TabIndex = 11;
      // 
      // ctrlExpertBtn1
      // 
      this.ctrlExpertBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.ctrlExpertBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.ctrlExpertBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.ctrlExpertBtn1.BorderRadius = 10;
      this.ctrlExpertBtn1.BorderSize = 0;
      this.ctrlExpertBtn1.FlatAppearance.BorderSize = 0;
      this.ctrlExpertBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ctrlExpertBtn1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctrlExpertBtn1.ForeColor = System.Drawing.Color.White;
      this.ctrlExpertBtn1.Location = new System.Drawing.Point(384, 406);
      this.ctrlExpertBtn1.Name = "ctrlExpertBtn1";
      this.ctrlExpertBtn1.Size = new System.Drawing.Size(132, 45);
      this.ctrlExpertBtn1.TabIndex = 5;
      this.ctrlExpertBtn1.Text = "Save";
      this.ctrlExpertBtn1.TextColor = System.Drawing.Color.White;
      this.ctrlExpertBtn1.UseVisualStyleBackColor = false;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.DimGray;
      this.btnCancel.BackgroundColor = System.Drawing.Color.DimGray;
      this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnCancel.BorderRadius = 10;
      this.btnCancel.BorderSize = 0;
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(532, 406);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(132, 45);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.TextColor = System.Drawing.Color.White;
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // chbIsActive
      // 
      this.chbIsActive.AccessibilityEnabled = true;
      this.chbIsActive.BeforeTouchSize = new System.Drawing.Size(173, 24);
      this.chbIsActive.Checked = true;
      this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chbIsActive.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chbIsActive.ForeColor = System.Drawing.SystemColors.InactiveBorder;
      this.chbIsActive.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
      this.chbIsActive.Location = new System.Drawing.Point(388, 179);
      this.chbIsActive.Name = "chbIsActive";
      this.chbIsActive.Size = new System.Drawing.Size(173, 24);
      this.chbIsActive.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
      this.chbIsActive.TabIndex = 12;
      this.chbIsActive.Text = "Is Active";
      this.chbIsActive.ThemeName = "Metro";
      // 
      // frmAddUpdatePlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(674, 458);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.ctrlExpertBtn1);
      this.Controls.Add(this.panelDown);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmAddUpdatePlayer";
      this.Text = "Add New Player";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelDown.ResumeLayout(false);
      this.panelDown.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chbIsActive)).EndInit();
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
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private Controls.ctrlExpertBtn ctrlExpertBtn1;
    private Controls.ctrlExpertBtn btnCancel;
    private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chbIsActive;
  }
}