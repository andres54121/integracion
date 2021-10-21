using System;
using System.Collections.Generic;
using Function.Integrations;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Functions.IntegrationsTest
{
    [Collection(nameof(TestColleccion))]
    public class WelcomeTest
    {
        private TestFixture testFixture;
        private HttpResponseMessage httpResponseMessage;

        public WelcomeTest(TestFixture fixture)
        {
            testFixture = fixture;
        }

        [Fact]
        public async Task WhenfunctioIsInvoked()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Bocchi");
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }

        [Fact]
        public async Task WhenResponseEndWith()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Bocchi");
            Assert.EndsWith("Success.", await httpResponseMessage.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task WhenResponseDoesNotContain()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Bocchi");
            Assert.DoesNotContain("Success.", await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
}
