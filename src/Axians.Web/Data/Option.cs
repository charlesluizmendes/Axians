namespace Axians.Web.Data
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Check { get; set; }

        public TaxType TaxType { get; set; }

        public bool Count { get; set; }
    }
}
