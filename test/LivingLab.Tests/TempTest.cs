namespace LivingLab.Tests;

public class TempTest
{
    [Fact]
    public void Double_InputIs4_Return8()
    {
        int result = Temp.Double(4);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Triple_InputIs4_Return12()
    {
        int result = Temp.Double(4);
        Assert.Equal(12, result);
    }
}