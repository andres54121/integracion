using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Functions.IntegrationsTest
{
    [CollectionDefinition(nameof(TestColleccion))]
    class TestColleccion : ICollectionFixture<TestFixture>
    {
    }
}
