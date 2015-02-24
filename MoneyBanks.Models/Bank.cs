using HelpPageErrorSimulator.Areas.HelpPage.ModelDescriptions;

namespace MoneyBanks.Models
{
    [ModelName("MoneyBank")]
    public class Bank
    {
        public string Name { get; set; }
        public string Special1 { get; set; }
        public string Special2 { get; set; }
    }
}