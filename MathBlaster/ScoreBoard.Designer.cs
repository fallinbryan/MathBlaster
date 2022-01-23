namespace MathBlaster
{
  partial class ScoreBoard
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
      this.scoreBoardText = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // scoreBoardText
      // 
      this.scoreBoardText.BackColor = System.Drawing.Color.Black;
      this.scoreBoardText.Font = new System.Drawing.Font("Lemon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreBoardText.ForeColor = System.Drawing.Color.LavenderBlush;
      this.scoreBoardText.Location = new System.Drawing.Point(12, 51);
      this.scoreBoardText.Name = "scoreBoardText";
      this.scoreBoardText.Size = new System.Drawing.Size(343, 387);
      this.scoreBoardText.TabIndex = 0;
      this.scoreBoardText.Text = "Kian\t|\t3400\nMaria\t|\t2100\nLucas\t|\t500";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(23, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(312, 32);
      this.label1.TabIndex = 1;
      this.label1.Text = "Top 10 High Scores";
      // 
      // ScoreBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(367, 449);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.scoreBoardText);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ScoreBoard";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Score Board";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox scoreBoardText;
    private System.Windows.Forms.Label label1;
  }
}