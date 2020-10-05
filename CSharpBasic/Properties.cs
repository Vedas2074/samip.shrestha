class Human
{
    internal string name;
    byte age = 23;

    public byte Age
    {

        get
        {
            return age;
        }
        set
        {
            if(value > 20 && value < 30)
            age = value;
        }
    }
    //Autoimplemeted property
    public string Name { get; set; }//private set yo class le matra use garna lai
    //Readonly property
    public string Address { get; set;}


}