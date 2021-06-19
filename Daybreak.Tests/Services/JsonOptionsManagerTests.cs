using Daybreak.Services.Options;
using Daybreak.Tests.Models;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;

namespace Daybreak.Tests.Services
{
    [TestClass]
    public class JsonOptionsManagerTests
    {
        private JsonOptionsManager jsonOptionsManager;

        [TestInitialize]
        public void TestInitialize()
        {
            File.Delete("Daybreak.Options.json");
            this.jsonOptionsManager = new JsonOptionsManager(new Mock<ILogger<JsonOptionsManager>>().Object);
        }

        [TestMethod]
        public void GetOptions_ReturnsDefaultValue()
        {
            var options = this.jsonOptionsManager.GetOptions<MockOptions>();

            options.Should().BeNull();
        }

        [TestMethod]
        public void GetOptions_ReturnsSavedValue()
        {
            this.SetupSomeMockOptionsValue();

            var options = this.jsonOptionsManager.GetOptions<MockOptions>();

            options.Should().BeEquivalentTo(new MockOptions { SomeValue = "hello" });
        }

        [TestMethod]
        public void UpdateOptions_Succeeds()
        {
            this.jsonOptionsManager.UpdateOptions(new MockOptions() { SomeValue = "world" });
        }

        private void SetupSomeMockOptionsValue()
        {
            this.jsonOptionsManager.UpdateOptions(new MockOptions { SomeValue = "hello" });
        }
    }
}
