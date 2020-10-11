using System;
using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string>() { "Ram", "sita" };
        names.Add("sushil");
        names.Add("Ragav");
        names.Add("avinas");
        names.Sort();
    }

    public void LearnAboutDictonary()
    {
        //holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };

        countryCapitals.Add("nepal", "kathmandu");
        countryCapitals.Add("india", "Delhi");
        countryCapitals.Add("usa", "wdc");
        countryCapitals.Add("Russia", "Mosco");
    }
}
