using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ludo.Modules.Players;

namespace Ludo.Forms
{
    public partial class StartMenu : Form
    {
        static List<IPlayer> players = new List<IPlayer>();
        public StartMenu()
        {
            InitializeComponent();
            FillThoseCombos();
        }

        private void HideLists()
        {
            lblPlayer1.Visible = false;
            lblPlayer2.Visible = false;
            lblPlayer3.Visible = false;
            lblPlayer4.Visible = false;
            cmbPlayer1.Visible = false;
            cmbPlayer2.Visible = false;
            cmbPlayer3.Visible = false;
            cmbPlayer4.Visible = false;
            btnPlay.Visible = false;
            btnCancel.Visible = false;
            //btnStartGameOpts.Enabled = false;
            //btnAbout.Enabled = false;
            //btnExit.Enabled = false;
        }

        private void ShowLists()
        {
            lblPlayer1.Visible = true;
            lblPlayer2.Visible = true;
            lblPlayer3.Visible = true;
            lblPlayer4.Visible = true;
            cmbPlayer1.Visible = true;
            cmbPlayer2.Visible = true;
            cmbPlayer3.Visible = true;
            cmbPlayer4.Visible = true;
            btnPlay.Visible = true;
            btnCancel.Visible = true;
            //btnStartGameOpts.Enabled = true;
            //btnAbout.Enabled = true;
            //btnExit.Enabled = true;
        }

        private void FillThoseCombos()
        {
            cmbPlayer1.DataSource = new List<string> { "None", "Human", "AI" };
            cmbPlayer1.SelectedIndex = 1;
            cmbPlayer2.DataSource = new List<string> { "None", "Human", "AI" };
            cmbPlayer2.SelectedIndex = 1;
            cmbPlayer3.DataSource = new List<string> { "None", "Human", "AI" };
            cmbPlayer4.DataSource = new List<string> { "None", "Human", "AI" };
        }

        private void btnStartGameOpts_Click(object sender, EventArgs e)
        {
            ShowLists();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Just for fun to refresh my coding skills.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                InitPlayers();
                System.Threading.Thread t = new System.Threading.Thread(
                    new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message, "OMG Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideLists();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            HideLists();
        }
        
        public static void ThreadProc()
        {
            Board gameBoard = new Board(players.Count);
            Application.Run(gameBoard);
        }

        private void InitPlayers()
        {
            players = new List<IPlayer>();
            foreach (ComboBox ctr in
                        this.Controls.Cast<Control>().Where(
                            ctrl => ctrl.GetType() == typeof(ComboBox)
                    ))
            {
                switch (ctr.SelectedIndex)
                {
                    case 1:
                        HumanPlayer singlePlayer = new HumanPlayer(
                           Int32.Parse(ctr.Name.Substring(ctr.Name.Length - 1, 1)));
                        players.Add(singlePlayer);
                        break;
                    case 2:
                        throw new Exception("AI is not implemented yet, please pick another!");
                    case 0:
                        break;
                    default:
                        throw new Exception("Invalid selection of player!");
                }
            }
            if (players.Count < 2)
            {
                throw new Exception("You should at least play with 1 friend, loner!");
            }
        }
    }
}
