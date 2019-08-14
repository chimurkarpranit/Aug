namespace Day2
{
    public class Supplier
    {
        private int sID;
        public int SupplierID
        {
            get { return sID; }
            set { sID = value; }
        }
        private string company;
        public string CompanyName
        {
            get { return company; }
            set { company = value; }
        }
        private string contact;
        public string ContactName
        {
            get { return contact; }
            set { contact = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}