using System;

namespace Reply.Domain.ReplyContext.Commands.Outputs
{
    /// <summary>
    /// structure for OutPut Data
    /// </summary>
    public struct CreateInsuranceResult 
    {
        public CreateInsuranceResult(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
