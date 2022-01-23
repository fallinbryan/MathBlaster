namespace MathBlaster
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
      this.GameBoard = new System.Windows.Forms.PictureBox();
      this.PlayButton = new System.Windows.Forms.Button();
      this.PlayerKeyPress = new System.Windows.Forms.TextBox();
      this.ScoreBoard = new System.Windows.Forms.TextBox();
      this.scoreLable = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.myProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // GameBoard
      // 
      this.GameBoard.BackColor = System.Drawing.Color.Black;
      this.GameBoard.Location = new System.Drawing.Point(12, 77);
      this.GameBoard.Name = "GameBoard";
      this.GameBoard.Size = new System.Drawing.Size(1289, 758);
      this.GameBoard.TabIndex = 0;
      this.GameBoard.TabStop = false;
      // 
      // PlayButton
      // 
      this.PlayButton.Location = new System.Drawing.Point(12, 27);
      this.PlayButton.Name = "PlayButton";
      this.PlayButton.Size = new System.Drawing.Size(112, 35);
      this.PlayButton.TabIndex = 1;
      this.PlayButton.Text = "PLAY";
      this.PlayButton.UseVisualStyleBackColor = true;
      this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
      // 
      // PlayerKeyPress
      // 
      this.PlayerKeyPress.Enabled = false;
      this.PlayerKeyPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlayerKeyPress.Location = new System.Drawing.Point(568, 841);
      this.PlayerKeyPress.Name = "PlayerKeyPress";
      this.PlayerKeyPress.Size = new System.Drawing.Size(154, 49);
      this.PlayerKeyPress.TabIndex = 2;
      // 
      // ScoreBoard
      // 
      this.ScoreBoard.Enabled = false;
      this.ScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ScoreBoard.Location = new System.Drawing.Point(1201, 36);
      this.ScoreBoard.Name = "ScoreBoard";
      this.ScoreBoard.Size = new System.Drawing.Size(100, 35);
      this.ScoreBoard.TabIndex = 3;
      this.ScoreBoard.Text = "0";
      // 
      // scoreLable
      // 
      this.scoreLable.AutoSize = true;
      this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreLable.Location = new System.Drawing.Point(1122, 42);
      this.scoreLable.Name = "scoreLable";
      this.scoreLable.Size = new System.Drawing.Size(73, 25);
      this.scoreLable.TabIndex = 4;
      this.scoreLable.Text = "Score";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.myProgressToolStripMenuItem,
            this.changePlayerToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1305, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // highScoresToolStripMenuItem
      // 
      this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
      this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
      this.highScoresToolStripMenuItem.Text = "High Scores";
      this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
      // 
      // myProgressToolStripMenuItem
      // 
      this.myProgressToolStripMenuItem.Name = "myProgressToolStripMenuItem";
      this.myProgressToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
      this.myProgressToolStripMenuItem.Text = "My Progress";
      this.myProgressToolStripMenuItem.Click += new System.EventHandler(this.myProgressToolStripMenuItem_Click);
      // 
      // changePlayerToolStripMenuItem
      // 
      this.changePlayerToolStripMenuItem.Name = "changePlayerToolStripMenuItem";
      this.changePlayerToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
      this.changePlayerToolStripMenuItem.Text = "Change Player";
      this.changePlayerToolStripMenuItem.Click += new System.EventHandler(this.changePlayerToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1305, 902);
      this.Controls.Add(this.scoreLable);
      this.Controls.Add(this.ScoreBoard);
      this.Controls.Add(this.PlayerKeyPress);
      this.Controls.Add(this.PlayButton);
      this.Controls.Add(this.GameBoard);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Math Blaster";
      ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox GameBoard;
    private System.Windows.Forms.Button PlayButton;
    private System.Windows.Forms.TextBox PlayerKeyPress;
    private System.Windows.Forms.TextBox ScoreBoard;
    private System.Windows.Forms.Label scoreLable;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem myProgressToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changePlayerToolStripMenuItem;
  }
}

