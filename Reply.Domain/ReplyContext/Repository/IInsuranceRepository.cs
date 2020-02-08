using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyContext.Repository
{
    /// <summary>
    /// Contract of Repository  for Insurance Entity
    /// </summary>
    public interface IInsuranceRepository
    {   
        /// <summary>
        /// Method responsible for save a insurance
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Save(Insurance model);

        /// <summary>
        /// Method responsible for returb a list of insurance
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        IEnumerable<SearchInsuranceQueryResult> GetInsuranceByDocument(string document);

        /// <summary>
        /// Method resposible for return Report average data
        /// </summary>
        /// <returns></returns>
        ReportQueryResult GetReport();
    }
}
