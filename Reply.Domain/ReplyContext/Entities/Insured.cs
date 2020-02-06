using FluentValidator.Validation;
using Reply.Domain.ReplyContext.ValueObjects;
using Reply.Shared.Entities;

namespace Reply.Domain.ReplyContext.Entities
{
    public class Insured : Entity
    {
        public Insured(int age, Name name, Document document)
        {
            Age = age;
            Name = name;
            Document = document;

            AddNotifications(new ValidationContract()
            .Requires()
            .IsBetween(Age, 18, 100, nameof(Age), "A idade deve  estar entre 18 e 100 anos!")
            );

            AddNotifications(Name, Document);
        }

        public int Age { get; private set; }

        public Name Name { get; private set; }

        public Document Document { get; private set; }
    }
}
