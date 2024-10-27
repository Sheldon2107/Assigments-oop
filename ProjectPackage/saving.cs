using System;

namespace ProjectPackage;

public class saving
{

    public string id {get;set;}
    public float val{get;set;}
    public DateTime DateCreated { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public float TargetAmount { get; set; }

    //constructor that accept zero parameter
    public saving(){
        id = "2024";
        val = 10;
        Description="This saving is for main saving";
        DateCreated = DateTime.Now;
        Category = "Main Saving";
        TargetAmount = 500f;

    }

    //contstructor that accept one parameters - accept the value
    public saving(float val){
        this.val += val;
        DateCreated = DateTime.Now;
    }

    //constructor that accept four parameters - the value,description, category, and targetted Amount from user input 
    public saving( float val, string D, string c, float T ){
        Description = D;
        this.val += val;
        Category = c;
        TargetAmount = T;
        DateCreated = DateTime.Now;
    }
    public saving(string i, float v, string da, string de, string c, float T){
        id = i;
        val = v;
        string Datereceived = da;
        Description = de;
        Category = c;
        TargetAmount = T;
    }
}
