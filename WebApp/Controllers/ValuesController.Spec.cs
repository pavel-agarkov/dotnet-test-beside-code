using System.Collections.Generic;
using Xunit;

namespace WebApp.Controllers
{
    public class ValuesControllerSpec : IClassFixture<ValuesController>
    {
        private readonly ValuesController controller;

        public ValuesControllerSpec(ValuesController controller)
        {
            this.controller = controller;
        }

        [Fact]
        public async void Get_action_should_return_an_array_of_strings()
        {
            var result = await controller.Get();
            Assert.IsAssignableFrom<IEnumerable<string>>(result);
        }

        [Fact]
        public async void Get_by_id_action_should_return_a_value()
        {
            var result = await controller.Get(123);
            Assert.Equal("value", result);
        }
    }
}
