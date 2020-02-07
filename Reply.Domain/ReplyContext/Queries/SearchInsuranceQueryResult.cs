using System;

namespace Reply.Domain.ReplyContext.Queries
{
    /// <summary>
    /// class As Output model
    /// </summary>
    public struct SearchInsuranceQueryResult
    {        
        public Guid Id {get; set;}
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleValue { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal RiskRatePorcent { get; set; }
        public decimal RiskPrize { get; set; }
        public decimal PurePrize { get; set; }
        public decimal CommercialPrize { get; set; }
    }
}