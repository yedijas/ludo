using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Forms
{
    public partial class StartMenu : Form
    {
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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideLists();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            HideLists();
        }
    }
}
