using Reply.Domain.ReplyContext.ValueObjects;
using Reply.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Entities
{
    public class Insured:Entity
    {
        public int Age { get; private set; }

        public Name Name { get; private set; }

        public Document Document { get; private set; }
    }
}
