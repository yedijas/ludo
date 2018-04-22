using Ludo.Modules.Players;
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
    public partial class Board : Form
    {
        private List<IPlayer> players;

        public Board(int PlayersCount)
        {
            InitializeComponent();
        }

        public void SetPlayers(List<IPlayer> _players)
        {
            players = _players;
        }
    }
}
