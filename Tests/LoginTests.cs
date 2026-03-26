using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FakeStoreApi.Core
{
    public class LoginTests : TestBase
    {
        [Test]
        public async Task LoginTest()
        {
            var auth = new AuthHelper();
            var token = await auth.GetToken();

            Assert.IsNotNull(token);
        }
    }
}
