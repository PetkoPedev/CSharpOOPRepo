﻿using P08_MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08_MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<ISoldier> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => this.privates;

        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString()).AppendLine("Privates:");

            foreach (var pr in this.Privates)
            {
                sb.AppendLine($"  {pr.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
