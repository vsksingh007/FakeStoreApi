using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeStoreApi.Core;
using NUnit.Framework;

namespace FakeStoreApi
{
    public class TestBase
    {
        protected ApiHelper apiHelper;

        [SetUp]
        public void Setup()
        {
            apiHelper = new ApiHelper();
        }
    }
}
