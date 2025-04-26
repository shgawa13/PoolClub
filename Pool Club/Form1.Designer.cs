namespace Pool_Club
{
  partial class Form1
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
      this.iconHat = new FontAwesome.Sharp.IconButton();
      this.SuspendLayout();
      // 
      // iconHat
      // 
      this.iconHat.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.iconHat.FlatAppearance.BorderSize = 0;
      this.iconHat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconHat.IconChar = FontAwesome.Sharp.IconChar.HackerNews;
      this.iconHat.IconColor = System.Drawing.Color.Black;
      this.iconHat.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconHat.Location = new System.Drawing.Point(384, 145);
      this.iconHat.Name = "iconHat";
      this.iconHat.Size = new System.Drawing.Size(50, 48);
      this.iconHat.TabIndex = 0;
      this.iconHat.UseVisualStyleBackColor = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.iconHat);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private FontAwesome.Sharp.IconButton iconHat;
  }
}

