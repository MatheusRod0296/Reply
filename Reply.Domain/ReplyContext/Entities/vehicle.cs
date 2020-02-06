using Reply.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Entities
{
    public class Vehicle: Entity
    {
        public string Brand { get; private set; }

        public string Model { get; private set; }

        public decimal Value { get; private set; }
    }
}
