using System;

namespace ProjectPackage;

public class savingList
{
    private List<saving> savings {set;get;}

    public savingList()
    {
        savings = new List<saving>();
    }

    public void Add(saving saving)
    {
        savings.Add(saving);
    }

    

}
