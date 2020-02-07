using FluentValidator.Validation;
using Reply.Domain.ReplyContext.ValueObjects;
using Reply.Shared.Entities;

namespace Reply.Domain.ReplyContext.Entities
{
    /// <summary>
    /// class responsible for storing the values of a insurance
    /// and validate about your business    
    /// </summary>
    public class Insured : Entity
    {
        public Insured(int age, Name name, Document document)
        {
            Age = age;
            Name = name;
            Document = document;

            AddNotifications(new ValidationContract()
            .Requires()
            .IsBetween(Age, 17, 121, nameof(Age), "A idade deve  estar entre 18 e 120 anos!")
            );

            AddNotifications(Name, Document);
        }

        public int Age { get; private set; }

        public Name Name { get; private set; }

        public Document Document { get; private set; }
    }
}
