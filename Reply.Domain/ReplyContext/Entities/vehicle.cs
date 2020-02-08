using FluentValidator.Validation;
using Reply.Shared.Entities;

namespace Reply.Domain.ReplyContext.Entities
{
    /// <summary>
    /// Class is responsible for Storing  and Valid the values of a vehicle  
    /// </summary>
    public class Vehicle : Entity
    {
        public Vehicle(string brand, string model, decimal value)
        {
            Brand = brand;
            Model = model;
            Value = value;

            AddNotifications(new ValidationContract()
                .Requires()
                    .HasMinLen(Brand, 3, nameof(Brand), "A marca do veiculo deve  conter pelo menos 3 caracteres!")
                    .HasMinLen(Model, 3, nameof(Model), "O modelo do veiculo deve  conter pelo menos 3 caracteres!")
                    .HasMaxLen(Brand, 50, nameof(Brand), "A marca do veiculo deve conter menos de 50 caracteres!")
                    .HasMaxLen(Model, 50, nameof(Model), "O modelo do veiculo deve conter menos de 50 caracteres!")           
                    .IsGreaterThan(Value, 0, nameof(Value), "O Valor do veiculo não pode ser menor igual a Zero!")
                    .IsFalse((Value > 9999999999999999.99M),  nameof(Value), "O Valor do veiculo execeu o range!")
             
               );

        }

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public decimal Value { get; private set; }       
    }
}
