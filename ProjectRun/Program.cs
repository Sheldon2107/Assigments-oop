using System;
using ProjectPackage;

class Program
{
    static void Main(string[] args)
    {
        saving saving = new saving();

        process process = new process();
        process.initFirestore();
        var taskfb = Task.Run( async() => await process.RestoreSaving());
        taskfb.Wait();
    }
    
}
