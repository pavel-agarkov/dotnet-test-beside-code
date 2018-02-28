using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClassLibrary
{
    public class SomeServiceSpec
    {
        private readonly SomeService someService = new SomeService();

        [Fact]
        public void Should_return_SomeData()
        {
            var result = this.someService.GetSomeData(1);
            Assert.Equal(1, result.Id);
        }
    }
}
