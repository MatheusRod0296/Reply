using Dapper;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.Queries;
using Reply.Domain.ReplyContext.Repository;
using Reply.Infra.ReplyContext.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reply.Infra.ReplyContext.Repository
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly ReplyDataContext _context;

        public InsuranceRepository(ReplyDataContext context)
        {
            _context = context;
        }

       

        public IEnumerable<SearchInsuranceQueryResult> GetInsuranceByDocument(string document)
        {
            var command = $@"select  [Id] 
                                    ,[FirstName]
                                    ,[LastName] 
                                    ,[Document] 
                                    ,[Age] 
                                    ,[VehicleBrand] 
                                    ,[VehicleModel] 
                                    ,[VehicleValue] 
                                    ,[RiskRate] as RiskRatePorcent
                                    ,[RiskPrize] 
                                    ,[PurePrize]
                                    ,[CommercialPrize]
                         FROM Insurance where [Document] = @document";

            return _context.Connection.Query<SearchInsuranceQueryResult>(command, new {document});

        }

        public bool Save(Insurance model)
        {            

            var command = @"INSERT into [Insurance]
                                    (	[Id]
                                        ,[FirstName]
                                        ,[LastName]
                                        ,[Document]
                                        ,[Age]
                                        ,[VehicleBrand]
                                        ,[VehicleModel]
                                        ,[VehicleValue]
                                        ,[RiskRate]
                                        ,[RiskPrize]
                                        ,[PurePrize]
                                        ,[CommercialPrize])

                                        values(
                                             @Id
                                            ,@FirstName
                                            ,@LastName
                                            ,@Document
                                            ,@Age
                                            ,@VehicleBrand
                                            ,@VehicleModel
                                            ,@VehicleValue
                                            ,@RiskRate
                                            ,@RiskPrize
                                            ,@PurePrize
                                            ,@CommercialPrize
                                        )";

           

            _context.Connection.Execute(command, 
                new {    Id = model.Id
                        ,FirstName = model.Insured.Name.FirstName
                        ,LastName = model.Insured.Name.LastName
                        ,Document = model.Insured.Document.ToString()
                        ,Age = model.Insured.Age
                        ,VehicleBrand = model.Vehicle.Brand
                        ,VehicleModel = model.Vehicle.Model
                        ,VehicleValue = model.Vehicle.Value
                        ,RiskRate = model.RiskRate.Value
                        ,RiskPrize =model.RiskPrize.Value
                        ,PurePrize =   model.PurePrize.Value
                        ,CommercialPrize = model.CommercialPrize.Value
                });

            return true;
        }


        public ReportQueryResult GetToRelatorio()
        {
            var command = $@"select 
                                Sum(VehicleValue) / count(VehicleValue) as VehicleValue,
                                sum(RiskRate) / count(RiskRate) as RiskRatePorcent,
                                sum(RiskPrize) / count(RiskPrize) as RiskPrize,
                                sum(PurePrize) / count(PurePrize) as PurePrize,
                                sum(CommercialPrize) / count(CommercialPrize) as CommercialPrize

                                from Insurance";

            return _context.Connection.Query<ReportQueryResult>(command).FirstOrDefault();

        }
    }
}
