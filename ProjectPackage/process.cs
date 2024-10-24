using System;
namespace ProjectPackage;

public class process
{

    public saving saving =  new saving();
    private const string FIREBASE_PROJID = "kampungManage";
    private FirestoreDb db;
    private FirestoreDb db;

    public Business(){
        TransList = new TransactionList();
    }
    public void initFirestore() // all initialization of firebase
    {
        FirebaseApp.Create();
        db = FirestoreDb.Create(FIREBASE_PROJID);
        Console.WriteLine("Created Cloud FireStore client with project ID: {0}", FIREBASE_PROJID);
    }

    

}
