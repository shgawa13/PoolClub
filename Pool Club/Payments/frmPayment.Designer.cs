namespace Pool_Club.Payments
{
  partial class frmPayment
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.lblTitle = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.iconButton3 = new FontAwesome.Sharp.IconButton();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.iconButton2 = new FontAwesome.Sharp.IconButton();
      this.btnCancel = new Pool_Club.Controls.ctrlExpertBtn();
      this.btnSave = new Pool_Club.Controls.ctrlExpertBtn();
      this.ctrlPlayerCard1 = new Pool_Club.ctrlPlayerCard();
      this.panelMoney = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panelMoney.SuspendLayout();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(22, 421);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(219, 33);
      this.comboBox1.TabIndex = 13;
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblTitle.AutoSize = true;
      this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lblTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(411, 84);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(140, 25);
      this.lblTitle.TabIndex = 14;
      this.lblTitle.Text = "New Payment ";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
      this.panel1.Controls.Add(this.iconButton1);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(962, 121);
      this.panel1.TabIndex = 17;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Black;
      this.label4.Location = new System.Drawing.Point(52, 476);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 25);
      this.label4.TabIndex = 26;
      this.label4.Text = "Description :";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(52, 389);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(189, 25);
      this.label1.TabIndex = 17;
      this.label1.Text = "Member Ship Type :";
      // 
      // textBox1
      // 
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(8, 508);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(441, 112);
      this.textBox1.TabIndex = 18;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(10, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 25);
      this.label2.TabIndex = 21;
      this.label2.Text = "Total :";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Black;
      this.label3.Location = new System.Drawing.Point(30, 62);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(95, 25);
      this.label3.TabIndex = 22;
      this.label3.Text = "Amount :";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
      this.checkBox1.Location = new System.Drawing.Point(15, 12);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(110, 29);
      this.checkBox1.TabIndex = 23;
      this.checkBox1.Text = "Discount";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
      this.maskedTextBox1.Location = new System.Drawing.Point(96, 162);
      this.maskedTextBox1.Mask = "00000";
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(98, 32);
      this.maskedTextBox1.TabIndex = 24;
      this.maskedTextBox1.ValidatingType = typeof(int);
      // 
      // comboBox2
      // 
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "%5",
            "%10"});
      this.comboBox2.Location = new System.Drawing.Point(144, 59);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(153, 33);
      this.comboBox2.TabIndex = 25;
      // 
      // iconButton3
      // 
      this.iconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.iconButton3.FlatAppearance.BorderSize = 0;
      this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
      this.iconButton3.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton3.IconSize = 35;
      this.iconButton3.Location = new System.Drawing.Point(11, 475);
      this.iconButton3.Name = "iconButton3";
      this.iconButton3.Size = new System.Drawing.Size(35, 27);
      this.iconButton3.TabIndex = 28;
      this.iconButton3.UseVisualStyleBackColor = true;
      // 
      // iconButton1
      // 
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
      this.iconButton1.IconColor = System.Drawing.Color.Snow;
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 100;
      this.iconButton1.Location = new System.Drawing.Point(440, 10);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(82, 71);
      this.iconButton1.TabIndex = 16;
      this.iconButton1.UseVisualStyleBackColor = true;
      // 
      // iconButton2
      // 
      this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.iconButton2.FlatAppearance.BorderSize = 0;
      this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
      this.iconButton2.IconColor = System.Drawing.Color.SteelBlue;
      this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton2.IconSize = 35;
      this.iconButton2.Location = new System.Drawing.Point(11, 388);
      this.iconButton2.Name = "iconButton2";
      this.iconButton2.Size = new System.Drawing.Size(35, 27);
      this.iconButton2.TabIndex = 15;
      this.iconButton2.UseVisualStyleBackColor = true;
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
      this.btnCancel.Location = new System.Drawing.Point(830, 620);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 42);
      this.btnCancel.TabIndex = 20;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.TextColor = System.Drawing.Color.White;
      this.btnCancel.UseVisualStyleBackColor = false;
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
      this.btnSave.Location = new System.Drawing.Point(704, 620);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 42);
      this.btnSave.TabIndex = 19;
      this.btnSave.Text = "Save";
      this.btnSave.TextColor = System.Drawing.Color.White;
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // ctrlPlayerCard1
      // 
      this.ctrlPlayerCard1.BackColor = System.Drawing.SystemColors.Control;
      this.ctrlPlayerCard1.Location = new System.Drawing.Point(4, 122);
      this.ctrlPlayerCard1.Name = "ctrlPlayerCard1";
      this.ctrlPlayerCard1.Size = new System.Drawing.Size(954, 261);
      this.ctrlPlayerCard1.TabIndex = 29;
      // 
      // panelMoney
      // 
      this.panelMoney.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panelMoney.Controls.Add(this.label5);
      this.panelMoney.Controls.Add(this.comboBox2);
      this.panelMoney.Controls.Add(this.checkBox1);
      this.panelMoney.Controls.Add(this.label3);
      this.panelMoney.Controls.Add(this.label2);
      this.panelMoney.Controls.Add(this.maskedTextBox1);
      this.panelMoney.Location = new System.Drawing.Point(527, 392);
      this.panelMoney.Name = "panelMoney";
      this.panelMoney.Size = new System.Drawing.Size(431, 207);
      this.panelMoney.TabIndex = 30;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Black;
      this.label5.Location = new System.Drawing.Point(72, 166);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(23, 25);
      this.label5.TabIndex = 26;
      this.label5.Text = "$";
      // 
      // frmPayment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(962, 668);
      this.Controls.Add(this.panelMoney);
      this.Controls.Add(this.ctrlPlayerCard1);
      this.Controls.Add(this.iconButton3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.iconButton2);
      this.Controls.Add(this.comboBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPayment";
      this.Text = "Payment Subscription";
      this.Load += new System.EventHandler(this.frmPayment_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelMoney.ResumeLayout(false);
      this.panelMoney.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private FontAwesome.Sharp.IconButton iconButton2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label lblTitle;
    private FontAwesome.Sharp.IconButton iconButton1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private Controls.ctrlExpertBtn btnCancel;
    private Controls.ctrlExpertBtn btnSave;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Label label4;
    private FontAwesome.Sharp.IconButton iconButton3;
    private ctrlPlayerCard ctrlPlayerCard1;
    private System.Windows.Forms.Panel panelMoney;
    private System.Windows.Forms.Label label5;
  }
}