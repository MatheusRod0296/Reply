using FluentValidator;
using Reply.Domain.ReplyContext.Commands.Inputs;
using Reply.Domain.ReplyContext.Commands.Outputs;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.Repository;
using Reply.Domain.ReplyContext.ValueObjects;
using Reply.Shared.Commands;

namespace Reply.Domain.ReplyContext.Handlers
{
    /// <summary>
    /// This class is responsable for handling  Insurance
    /// </summary>
    public class InsuranceHandler : Notifiable, ICommandHandler<InsuranceCreateCommand>
    {
        private readonly IInsuranceRepository _iInsuranceRepository;

        public InsuranceHandler(IInsuranceRepository iInsuranceRepository)
        {
            _iInsuranceRepository = iInsuranceRepository;
        }

        /// <summary>
        /// Method responsible for create the properties necessaries
        /// in creating Insurance
        /// </summary>
        /// <param name="command"> Property has all values necessary for creating de final object</param>
        /// <returns></returns>
        public ICommandResult Handler(InsuranceCreateCommand command)
        {
            var document = new Document(command.InsuredCpf);
            var name = new Name(command.InsuredFirstName, command.InsuredLastName);
            var insured = new Insured(command.InsuredAge, name, document);
            decimal vehicleValue = 0;
            decimal.TryParse(command.VehicleValue, out vehicleValue);
            var vehicle = new Vehicle(command.VehicleBrand, command.VehicleModel, vehicleValue);
            var insurance = new Insurance(insured, vehicle);

            AddNotifications(insurance);

            if (Invalid)
                return new CommandResult(false, "Falha ao cadastrar Seguro!", Notifications);

            _iInsuranceRepository.Save(insurance);


            return new CommandResult(true, "Cadastrado com sucesso",
                new CreateInsuranceResult( insurance.Id, insurance.Insured.Name.ToString()));
        }
    }
}
