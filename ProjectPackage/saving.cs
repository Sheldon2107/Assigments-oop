namespace ProjectPackage;

public class saving
{
    public string id {get;set;}
    public float val{get;set;}
    public saving(){
        id = "";
        val = "";
    }
    public saving(float float.Parse(val)){
        this.val = val;
    }
    public saving( string id, float val ){
        this.id = id;
        this.val = val;
    }
}
