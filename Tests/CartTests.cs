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
            var cart = new
            {
                userId = 1,
                date = DateTime.Now,
                products = new[]
                {
            new { productId = 1, quantity = 1 }
        }
            };

            var response = await apiHelper.SendRequest("carts", Method.Post, cart);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
