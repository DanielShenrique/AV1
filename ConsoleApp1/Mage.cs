using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mage : Character
    {
        private int lvlLimiteToChange;

        public Mage(string Initialname)
        {
            name = Initialname;
            level = 50;
            lvlLimiteToChange = 50;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (level >= lvlLimiteToChange)
                    name = value;
            }
        }

        public override void Update()
        {
            Move();
        }
    }
}
