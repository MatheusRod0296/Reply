using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Shared.Entities
{
    /// <summary>
    /// Adbstract class difine rules
    /// for classes entities 
    /// </summary>
    public abstract class Entity: Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
