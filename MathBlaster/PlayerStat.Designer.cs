namespace MathBlaster
{
  partial class PlayerStat
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.additionProgress = new System.Windows.Forms.ProgressBar();
      this.subtractionProgress = new System.Windows.Forms.ProgressBar();
      this.multiplicationProgress = new System.Windows.Forms.ProgressBar();
      this.divisionProgress = new System.Windows.Forms.ProgressBar();
      this.playerNameLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Addition";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 163);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 22);
      this.label2.TabIndex = 1;
      this.label2.Text = "Division";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 129);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(147, 22);
      this.label3.TabIndex = 2;
      this.label3.Text = "Multiplication";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(133, 22);
      this.label4.TabIndex = 3;
      this.label4.Text = "Subtraction";
      // 
      // additionProgress
      // 
      this.additionProgress.ForeColor = System.Drawing.Color.LawnGreen;
      this.additionProgress.Location = new System.Drawing.Point(194, 62);
      this.additionProgress.Maximum = 12;
      this.additionProgress.Name = "additionProgress";
      this.additionProgress.Size = new System.Drawing.Size(444, 23);
      this.additionProgress.TabIndex = 4;
      // 
      // subtractionProgress
      // 
      this.subtractionProgress.ForeColor = System.Drawing.Color.LawnGreen;
      this.subtractionProgress.Location = new System.Drawing.Point(194, 93);
      this.subtractionProgress.Maximum = 12;
      this.subtractionProgress.Name = "subtractionProgress";
      this.subtractionProgress.Size = new System.Drawing.Size(444, 23);
      this.subtractionProgress.TabIndex = 5;
      // 
      // multiplicationProgress
      // 
      this.multiplicationProgress.ForeColor = System.Drawing.Color.LawnGreen;
      this.multiplicationProgress.Location = new System.Drawing.Point(194, 129);
      this.multiplicationProgress.Maximum = 12;
      this.multiplicationProgress.Name = "multiplicationProgress";
      this.multiplicationProgress.Size = new System.Drawing.Size(444, 23);
      this.multiplicationProgress.TabIndex = 6;
      // 
      // divisionProgress
      // 
      this.divisionProgress.ForeColor = System.Drawing.Color.LawnGreen;
      this.divisionProgress.Location = new System.Drawing.Point(194, 163);
      this.divisionProgress.Maximum = 12;
      this.divisionProgress.Name = "divisionProgress";
      this.divisionProgress.Size = new System.Drawing.Size(444, 23);
      this.divisionProgress.TabIndex = 7;
      // 
      // playerNameLabel
      // 
      this.playerNameLabel.AutoSize = true;
      this.playerNameLabel.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.playerNameLabel.Location = new System.Drawing.Point(283, 9);
      this.playerNameLabel.Name = "playerNameLabel";
      this.playerNameLabel.Size = new System.Drawing.Size(147, 22);
      this.playerNameLabel.TabIndex = 8;
      this.playerNameLabel.Text = "Player Name";
      // 
      // PlayerStat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(676, 222);
      this.Controls.Add(this.playerNameLabel);
      this.Controls.Add(this.divisionProgress);
      this.Controls.Add(this.multiplicationProgress);
      this.Controls.Add(this.subtractionProgress);
      this.Controls.Add(this.additionProgress);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PlayerStat";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PlayerStat";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ProgressBar additionProgress;
    private System.Windows.Forms.ProgressBar subtractionProgress;
    private System.Windows.Forms.ProgressBar multiplicationProgress;
    private System.Windows.Forms.ProgressBar divisionProgress;
    private System.Windows.Forms.Label playerNameLabel;
  }
}