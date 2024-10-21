namespace Axians.Web.Data
{
    public class Tax
    {
        public int Id { get; set; }
        public bool AddTaxLocation { get; set; }

        public List<Nut> Nuts { get; set; }
    }
}
