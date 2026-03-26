using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Core
{
    public class CartTests:TestBase
    {
        [Test]
        public async Task AddToCart()
        {
            var cart = new Cart
            {
                Id = 0,
                UserId = 0,
                Products = new List<Products>
            {
                new Products
                {
                    Id = 1,
                    Title = "Test Product",
                    Price = 99.99,
                    Description = "Sample product for testing",
                    Category = "Test Category",
                    Image = "http://example.com"
                }
            }
            };
            var response = await apiHelper.SendRequest("carts", Method.Post, cart);

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
