namespace KT1
{
    public class Building
    {
        private string _address;

        public string Address => _address;

        public Building(string address)
        {
            _address = address;
        }
    }
}