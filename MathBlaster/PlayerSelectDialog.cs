using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MathBlaster
{
  public partial class PlayerSelectDialog : Form
  {
    public Player SelectedPlayer { get; set; }
    public PlayerSelectDialog( SerializableDictionary<string,Player> playerList)
    {
      InitializeComponent();

      if(playerList != null && playerList.Count > 0)
      {
        playerSelectComboBox.Enabled = true;
        playerSelectComboBox.Visible = true;

        playerInputTextBox.Visible = false;
        playerInputTextBox.Enabled = false;

        foreach(KeyValuePair<string,Player> playerKVP in playerList)
        {
          playerSelectComboBox.Items.Add(playerKVP.Value);
        }
      }
      else
      {
        playerSelectComboBox.Enabled = false;
        playerSelectComboBox.Visible = false;

        playerInputTextBox.Visible = true;
        playerInputTextBox.Enabled = true;
        playerInputTextBox.Focus();
        newPlayerButton.Enabled = false;
      }

    }

    private void newPlayerButton_Click(object sender, EventArgs e)
    {
      playerSelectComboBox.Enabled = false;
      playerSelectComboBox.Visible = false;
      
      playerInputTextBox.Visible = true;
      playerInputTextBox.Enabled = true;
      playerInputTextBox.Focus(); 
      
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
      if(playerSelectComboBox.Enabled)
      {
        SelectedPlayer = (Player)playerSelectComboBox.SelectedItem;
      }
      else
      {
        SelectedPlayer = new Player {  Name = playerInputTextBox.Text };
      }

      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
