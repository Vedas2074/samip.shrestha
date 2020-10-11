public class Calculator
{
    public static int Sum(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
    public static double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }
    public static T Sum<T>(T firstNum, T secondNum)
    {
        return firstNum;
    }
}