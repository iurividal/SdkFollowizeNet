using NUnit.Framework;

namespace SdkFollowizeNet_Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var key = SdkFollowizeNet.Utils.GetKeyTeam("Empresa1");

            Assert.Pass();
        }
    }
}