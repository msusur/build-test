using Xunit;

namespace BuildTest.Tests
{
    // ReSharper disable InconsistentNaming
    public class BuildTestClassTest
    {
        //[Fact]
        public void Test_That_Fails()
        {
            Assert.True(new TestClass().False());
        }

        [Fact]
        public void Test_That_Passes()
        {
            Assert.True(new TestClass().True());
        }
    }
}