using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertDemo
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapons();
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };
        }

        public List<string> Weapons { get; set; }

        public string Name { get; set; }
        
        public int Health { get; set; }

        public string Nickname { get; set; }
        public bool IsNoob { get; set; }

        public void Sleep()
        {
            var rnd = new Random();
            var healthIncrease = rnd.Next(1, 101);
            Health += healthIncrease;
        }

        public string GenerateName()
        {
            var names = new[] {"Baratheon", "Starks", "Greyjoys", "Lannisters", "Targarean", "Tullys"};
            return names[new Random().Next(0, names.Length)];
        }
    }
}
