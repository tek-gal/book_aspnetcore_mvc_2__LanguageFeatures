namespace LanguageFeatures.Models {
    public class Product {

        public Product(string name, string category, Product related, bool inStock) 
        {
            this.Name = name;
                this.Category = category;
                this.Related = related;
                this.InStock = inStock;
               
        }
                public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

        public Product(bool InStock = true) {
            this.InStock = InStock;
        }

        public static Product[] GetProducts () {
            Product kayak = new Product {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M,
            };

            Product lifejacket = new Product(false) {
                Name = "Lifejacket",
                Price = 48.95M,
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}