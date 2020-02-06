using Reply.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Entities
{
    public class Insurance: Entity
    {

        public Insured Insured { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public decimal RiskRate { get; private set; }
        public decimal RiskPrize { get; private set; }
        public decimal PurePrize { get; private set; }
        public decimal commercialPrize { get; private set; }
    }
}
