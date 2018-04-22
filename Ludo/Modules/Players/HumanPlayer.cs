using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Modules.Players
{
    public class HumanPlayer : IPlayer
    {
        private string name;

        public HumanPlayer()
        {
            name = "Human Player";
        }

        public HumanPlayer(int Order)
        {
            name = "Human Player " + Order.ToString();
        }

        public HumanPlayer(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(name))
                return "Human Player";
            else
                return name;
        }

        public bool IsHuman()
        {
            return true;
        }

        public int DoDiceRoll()
        {
            RNGCryptoServiceProvider rnGesus = new RNGCryptoServiceProvider();
            byte numberSides = (byte)6;
            byte[] randomNumber = new byte[1];
            do
            {
                rnGesus.GetBytes(randomNumber);
            }
            while (!IsFairRoll(randomNumber[0], numberSides));
            return (int)((randomNumber[0] % numberSides) + 1);
        }

        private static bool IsFairRoll(byte roll, byte numSides)
        {
            int fullSetsOfValues = Byte.MaxValue / numSides;
            return roll < numSides * fullSetsOfValues;
        }
    }
}
