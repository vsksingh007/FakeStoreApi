using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Core
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Products> Products { get; set; }
    }

    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}
