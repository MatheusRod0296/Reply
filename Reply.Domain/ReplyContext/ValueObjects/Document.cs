using FluentValidator.Validation;
using Reply.Shared.Entities;
using Reply.Shared.Validation;

namespace Reply.Domain.ReplyContext.ValueObjects
{
    /// <summary>
    /// Class storage Cpf value.
    /// </summary>
    public class Document: Entity
    {
        public Document(string number)
        {
            Number = number;

            AddNotifications(new ValidationContract()
           .Requires()
              .IsTrue(CPFValidation.Validate(Number), "Document", "Cpf invalido")
         );
        }

        public string Number { get; private set; }
                    

        public override string ToString()
        {
            return Number;
        }
    }
}
