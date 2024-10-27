using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace ProjectPackage;

public class process
{
    //Pure class = saving
    //Group everything in process.cs, to isolate database connecting system here
    

    public saving saving =  new saving();
    private const string FIREBASE_PROJID = "kampungmanage";
    private FirestoreDb db;

    public process(){
        saving saving = new saving();
    }
    public void initFirestore() // all initialization of firebase
    {
        FirebaseApp.Create();
        db = FirestoreDb.Create(FIREBASE_PROJID);
        Console.WriteLine("Created Cloud FireStore client with project ID: {0}", FIREBASE_PROJID);
    }

    public async Task SaveSaving( saving saving )
    {   // public method to save saving
        CollectionReference collectionRef = db.Collection("Saving"); // a collection for saving 
        DocumentReference docRef = collectionRef.Document(saving.id); // create a row name ID 

        Dictionary<string, object> values = new Dictionary<string, object>
        {
            {"ID", saving.id},
            {"Value", saving.val.ToString()},
            {"Date Created ", saving.DateCreated.ToString()},
            {"Description" , saving.Description},
            {"Category ", saving.Category},
            {"Targetted Amount ", saving.TargetAmount.ToString()}
        };
        
        Console.WriteLine("Adding doc with ID " +docRef.Id);
        await docRef.SetAsync(values);
    }

    public async Task RestoreSaving()
    {
        float val = 0;
        string id;
        string date;
        string desc ;
        string cate ;
        float target;
        Query collectionQuery = db.Collection("Saving");
        QuerySnapshot allQuerySnapshot = await collectionQuery.GetSnapshotAsync(); //download values from firestore database - retrieving

        foreach (DocumentSnapshot documentSnapshot in allQuerySnapshot.Documents)
        {
            Dictionary <string,object> data = documentSnapshot.ToDictionary();
            val = float.Parse(data["Value"].ToString());
            id = data["ID"].ToString();
            
            date =  data["Date Created "].ToString();
            desc = data["Description"].ToString();
            cate = data["Category "].ToString();
            target = float.Parse(data["Targetted Amount "].ToString());

            Console.WriteLine("successfully retrieve saving from firestore");
            saving saved = new saving(id,val,date,desc,cate,target);
            savingList savinglist = new savingList();
            savinglist.Add(saved);
            Console.WriteLine("Succesfully save the saving to saving list");
        }
        
    }
}

