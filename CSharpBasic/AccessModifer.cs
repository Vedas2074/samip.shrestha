namespace AccessModifierAndMethods

{
    class AccessModifier
{
    int x;
    int y;
    internal void DoSomething()
    {

    }
    public int CalculateAverage()
    {
        DoSomething();
        // calculate average
        return 0;
    }

}
}