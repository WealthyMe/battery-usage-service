using BatteryConsumption.Controllers;
using NUnit.Framework;

namespace BatteryConsumption.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOneBatteryUsageOfDevice()
        {
            BatteryConsumptionController batteryConsumption = new BatteryConsumptionController();
            Assert.Pass();
        }
    }
}