
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monk : Character
    {
        private int lvlLimiteToChange;

        public Monk(string Initialname)
        {
            name = Initialname;
            level = 80;
            lvlLimiteToChange = 80;
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
