namespace Test.Builder.Products
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public string GetPart()
        {
            string parts = "";
            foreach (string part in _parts)
            {
                parts = parts + part + " ";
            }
            return parts;
        }
    }
}
