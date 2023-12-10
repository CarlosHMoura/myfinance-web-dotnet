using myfinance_web_dotnet.Enumerations;

namespace myfinance_web_dotnet.Domain
{
    public record AccountPlanModel
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public TypeAccountEnum Type { get; set; }
        public bool? Active { get; set; }
        public virtual ICollection<TransactionModel> Transactions { get; set; } = new List<TransactionModel>();
    }
}
