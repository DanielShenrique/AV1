﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Character
    {
        protected string name;
        protected int level;


        public abstract void Update();

        protected void Move()
        {
        }

    }
}
