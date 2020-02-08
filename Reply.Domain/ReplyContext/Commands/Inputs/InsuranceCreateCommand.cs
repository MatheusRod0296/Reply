using Reply.Shared.Commands;

namespace Reply.Domain.ReplyContext.Commands.Inputs
{
    /// <summary>
    /// structure for Input Data
    /// </summary>
    public struct InsuranceCreateCommand : ICommand
    {
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleValue { get; set; }

        public string InsuredCpf { get; set; }
        public string InsuredFirstName { get; set; }
        public string InsuredLastName { get; set; }
        public int InsuredAge { get; set; }
    }
}
