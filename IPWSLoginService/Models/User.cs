namespace IPWSLoginService.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Pword { get; set; }
        public string? EmailAddress { get; set; }
        public string? AgentCompanyCode { get; set; }
        public int AgentCompanyID { get; set; }
        public string? AgentCompanyName { get; set; }
        public string? AccRole { get; set; }
        public int AccessView { get; set; }
        public int AccessCreate { get; set; }
        public int AccessEdit { get; set; }
        public int AccessInactive { get; set; }
        public int AccessRelease { get; set; }
        public int AccessApprove { get; set; }
        public int AccessReject { get; set; }
    }

}
