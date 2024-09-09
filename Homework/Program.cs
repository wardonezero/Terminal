using Homework;
using static System.Console;
string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Pictures\Screenshots";
ShowlargrFileWithoutLinq(path);
static void ShowlargrFileWithoutLinq(string path)
{
    DirectoryInfo directory = new(path);
    FileInfo[] files = directory.GetFiles();
    SortFiles(files);
    for (int i = 0; i < 5; i++)
    {
        WriteLine($"{files[i].Name} : {files[i].Length / 1048576f:F2}MB");
    }
}
static FileInfo[] SortFiles(FileInfo[] folder)
{
    FileInfo temp;
    for (int i = 0; i < folder.Length; i++)
    {
        for (int j = i + 1; j < folder.Length; j++)
        {
            if (folder[i].Length < folder[j].Length)
            {
                temp = folder[i];
                folder[i] = folder[j];
                folder[j] = temp;
            }
        }
    }
    return folder;
}

