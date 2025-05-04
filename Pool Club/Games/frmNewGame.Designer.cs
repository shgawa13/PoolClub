namespace Pool_Club.Games
{
  partial class frmNewGame
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
      this.label1 = new System.Windows.Forms.Label();
      this.ctrlExpertBtn1 = new Pool_Club.Controls.ctrlExpertBtn();
      this.ctrlExpertBtn2 = new Pool_Club.Controls.ctrlExpertBtn();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(310, 210);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "NewGames Form";
      // 
      // ctrlExpertBtn1
      // 
      this.ctrlExpertBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.ctrlExpertBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
      this.ctrlExpertBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.ctrlExpertBtn1.BorderRadius = 5;
      this.ctrlExpertBtn1.BorderSize = 0;
      this.ctrlExpertBtn1.FlatAppearance.BorderSize = 0;
      this.ctrlExpertBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ctrlExpertBtn1.ForeColor = System.Drawing.Color.White;
      this.ctrlExpertBtn1.Location = new System.Drawing.Point(522, 88);
      this.ctrlExpertBtn1.Name = "ctrlExpertBtn1";
      this.ctrlExpertBtn1.Size = new System.Drawing.Size(142, 51);
      this.ctrlExpertBtn1.TabIndex = 2;
      this.ctrlExpertBtn1.Text = "Test";
      this.ctrlExpertBtn1.TextColor = System.Drawing.Color.White;
      this.ctrlExpertBtn1.UseVisualStyleBackColor = false;
      this.ctrlExpertBtn1.Click += new System.EventHandler(this.ctrlExpertBtn1_Click);
      // 
      // ctrlExpertBtn2
      // 
      this.ctrlExpertBtn2.BackColor = System.Drawing.Color.SlateBlue;
      this.ctrlExpertBtn2.BackgroundColor = System.Drawing.Color.SlateBlue;
      this.ctrlExpertBtn2.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.ctrlExpertBtn2.BorderRadius = 10;
      this.ctrlExpertBtn2.BorderSize = 0;
      this.ctrlExpertBtn2.FlatAppearance.BorderSize = 0;
      this.ctrlExpertBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ctrlExpertBtn2.ForeColor = System.Drawing.Color.White;
      this.ctrlExpertBtn2.Location = new System.Drawing.Point(210, 88);
      this.ctrlExpertBtn2.Name = "ctrlExpertBtn2";
      this.ctrlExpertBtn2.Size = new System.Drawing.Size(105, 55);
      this.ctrlExpertBtn2.TabIndex = 3;
      this.ctrlExpertBtn2.Text = "ctrlExpertBtn2";
      this.ctrlExpertBtn2.TextColor = System.Drawing.Color.White;
      this.ctrlExpertBtn2.UseVisualStyleBackColor = false;
      // 
      // frmNewGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ctrlExpertBtn2);
      this.Controls.Add(this.ctrlExpertBtn1);
      this.Controls.Add(this.label1);
      this.Name = "frmNewGame";
      this.Text = "New Game";
      this.Load += new System.EventHandler(this.frmNewGame_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private Controls.ctrlExpertBtn ctrlExpertBtn1;
    private Controls.ctrlExpertBtn ctrlExpertBtn2;
  }
}