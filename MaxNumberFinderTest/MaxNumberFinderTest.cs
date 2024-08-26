using MaxNumberFinder;
using Xunit;
namespace MaxNumberFinderTest
{
    public class MaxNumberFinderTest
    {
        [Theory]
        [InlineData(6, 10, 10)]   // 10 е по-голямо от 5
        [InlineData(-236, -112, -112)]
        public void MaxNumberFinder_WithInputNumbers_ShouldReturnMaxNumber(int a, int b, int MaxNumber)
        {
            int result = MaxNumber.MaxNumberFinder(a, b, MaxNumber);
            Assert.Equal(MaxNumber, result);
        }
    }
}