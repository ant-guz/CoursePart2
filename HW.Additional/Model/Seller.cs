namespace HW.Additional.Model
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumbOfSelling { get; set; }
        public List<Owner> Owners { get; set; }
    }
}
