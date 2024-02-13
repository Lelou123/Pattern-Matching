namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(2, Calculator(1,1));
    }
    
    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Calculator(2, 2));
    }

    private int Calculator(int a, int b) => a + b;
    
    
}