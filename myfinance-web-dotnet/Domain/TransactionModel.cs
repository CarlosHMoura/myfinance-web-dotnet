namespace myfinance_web_dotnet.Domain
{
    public record TransactionModel
    {
        public int Id { get; set; }
        public string? History { get; set; }
        public string? Type { get; set; }
        public decimal Value { get; set; }
        public int AccountPlanId { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public AccountPlanModel AccountPlan { get; set; } = new AccountPlanModel();
    }
}
