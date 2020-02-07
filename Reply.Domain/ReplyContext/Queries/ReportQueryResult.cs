using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Queries
{
    /// <summary>
    /// Class as OutPut model
    /// </summary>
    public struct ReportQueryResult
    {
        public decimal VehicleValue { get; set; }
        public decimal RiskRatePorcent { get; set; }
        public decimal RiskPrize { get; set; }
        public decimal PurePrize { get; set; }
        public decimal CommercialPrize { get; set; }
    }
}
