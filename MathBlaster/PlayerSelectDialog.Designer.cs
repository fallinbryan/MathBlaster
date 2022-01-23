namespace MathBlaster
{
  partial class PlayerSelectDialog
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
      this.playerSelectComboBox = new System.Windows.Forms.ComboBox();
      this.OkButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.newPlayerButton = new System.Windows.Forms.Button();
      this.playerInputTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // playerSelectComboBox
      // 
      this.playerSelectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerSelectComboBox.FormattingEnabled = true;
      this.playerSelectComboBox.Location = new System.Drawing.Point(12, 52);
      this.playerSelectComboBox.Name = "playerSelectComboBox";
      this.playerSelectComboBox.Size = new System.Drawing.Size(252, 39);
      this.playerSelectComboBox.TabIndex = 0;
      // 
      // OkButton
      // 
      this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OkButton.Location = new System.Drawing.Point(189, 144);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(75, 43);
      this.OkButton.TabIndex = 1;
      this.OkButton.Text = "OK";
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(192, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = "Who is Playing";
      // 
      // newPlayerButton
      // 
      this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newPlayerButton.Location = new System.Drawing.Point(12, 144);
      this.newPlayerButton.Name = "newPlayerButton";
      this.newPlayerButton.Size = new System.Drawing.Size(98, 43);
      this.newPlayerButton.TabIndex = 3;
      this.newPlayerButton.Text = "NEW";
      this.newPlayerButton.UseVisualStyleBackColor = true;
      this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
      // 
      // playerInputTextBox
      // 
      this.playerInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerInputTextBox.Location = new System.Drawing.Point(13, 52);
      this.playerInputTextBox.Name = "playerInputTextBox";
      this.playerInputTextBox.Size = new System.Drawing.Size(251, 38);
      this.playerInputTextBox.TabIndex = 4;
      this.playerInputTextBox.Visible = false;
      // 
      // PlayerSelectDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(278, 202);
      this.Controls.Add(this.playerInputTextBox);
      this.Controls.Add(this.newPlayerButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.playerSelectComboBox);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PlayerSelectDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pick a Player";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox playerSelectComboBox;
    private System.Windows.Forms.Button OkButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button newPlayerButton;
    private System.Windows.Forms.TextBox playerInputTextBox;
  }
}