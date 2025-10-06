namespace Test;

public class UnitTest1
{
    public int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 4)]
    public void TestSum(int number1, int number2, int result)
    {
        Assert.True(Sum(number1, number2) == result);
        }
}