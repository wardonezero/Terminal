using System.ComponentModel;
using Terminal;
using static System.Console;
//1
var worker = new Worker();
worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
worker.DoWork(23, WorkType.Reports);
//worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e);
void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
{
    WriteLine($"Hours worked: {e.Hours.ToString()} {e.WorkType}");
}
static void Worker_WorkCompleted(object sender, EventArgs e)
{
    WriteLine($"Worker is done!");
}

//2
string path = @"C:\Users\Administrator\Pictures\Screenshots";
ShowlargrFileWithoutLinq(path);
static void ShowlargrFileWithoutLinq(string path)
{
    DirectoryInfo directory = new DirectoryInfo(path);
    FileInfo[] files = directory.GetFiles();
    foreach (FileInfo item in files)
    {
        WriteLine($"{item.Name} : {item.Length}");
    }
}