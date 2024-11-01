﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int Power = 100;
        public Paladin(string name) : base(name, Power)
        {
        }
        public override string CastAbility()
        {
            return base.CastAbility() + $"healed for {Power}"; ;
        }
    }
}
