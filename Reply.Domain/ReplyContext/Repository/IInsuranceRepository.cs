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
        bool Save(Insurance model);

        IEnumerable<SearchInsuranceQueryResult> GetInsuranceByDocument(string document);

        ReportQueryResult GetToRelatorio();
    }
}
