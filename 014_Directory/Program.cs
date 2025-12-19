// Director(Static),DirectoryInfo, File(Static), and FileInfo

// Directory

// Створення папки, а потім папку в папку
/*string path = @"Folder/Video";
Directory.CreateDirectory(path);*/

// Видалення папки
/*string path = @"Folder/Images";
Directory.Delete(path, true);*/

// Переіменнування і переміщення папки
/*string pathFrom = @"Folder/Video";
string pathTo = @"Folder/Video100";
Directory.Move(pathFrom, pathTo);*/

/*string pathFrom = @"Folder/Video100";
string pathTo = @"Folder/Film/Video100";
Directory.Move(pathFrom, pathTo);*/

// Перевірка на існування папки
/*string path = @"Folder/Film";
if(Directory.Exists(path))
    Console.WriteLine("+");
else
    Console.WriteLine("-");*/

// Доступ до батьківської папки
/*string path = @"Folder/Film/Video100";
DirectoryInfo parent = Directory.GetParent(path);

Console.WriteLine(parent.FullName);*/

// Передік логічних дисків
/*string[] drives =  Directory.GetLogicalDrives();
foreach(var drive in drives)
    Console.WriteLine(drive);*/

// Перелік папок
/*string path = @"Folder\Film\Video100";
*//*string[] directories1 = Directory.GetDirectories(path);*//* //Папки
string[] directories = Directory.GetFiles(path);                //Файли
foreach(var directory in directories)
{
    FileInfo directoryInfo = new FileInfo(directory);
    Console.WriteLine(directoryInfo.Name);
}*/

// Перелік файлів і папок
/*string path = @"Folder1";
string[] entries = Directory.GetFileSystemEntries(path);

foreach (string entry in entries)
{
    Console.WriteLine(entry);
}*/


// File


/*string path = @"Folder/Film/data2.txt";
File.Create(path);*/

/*string path = @"Folder/Film/Video100/gg.bmp";
File.Delete(path);*/

/*string pathFrom = @"Folder/Film/image1.jpg";
string pathTo = @"Folder/image1.jpg";
File.Copy(pathFrom, pathTo);*/


// DirectoryInfo
/*string path = @"Folder";
DirectoryInfo directoryInfo = new DirectoryInfo(path);
Console.WriteLine(directoryInfo.Name);
Console.WriteLine(directoryInfo.FullName);
Console.WriteLine(directoryInfo.Parent.Name);
Console.WriteLine(directoryInfo.Root.Name);
Console.WriteLine(directoryInfo.CreationTime);
Console.WriteLine(directoryInfo.LastWriteTime);*/


// FileInfo
/*string path = @"Folder/myFile.txt";
FileInfo fileInfo = new FileInfo(path);
fileInfo.Create();
Console.WriteLine(fileInfo.Length);*/


void Find(string fileName, DirectoryInfo root)
{
    foreach (FileInfo file in root.GetFiles())
    {
        if (file.Name == fileName)
        {
            Console.WriteLine(file.FullName);
        }
    }

    foreach(DirectoryInfo file in root.GetDirectories())
    {   
        Find(fileName, file);
    }
}
void Delete(string fileName, DirectoryInfo root) 
{
    foreach (FileInfo file in root.GetFiles())
    {
        if (file.Name == fileName)
        {
            Console.WriteLine(file.FullName);
            file.Delete();
        }
    }

    foreach (DirectoryInfo file in root.GetDirectories())
    {
        Delete(fileName, file);
    }

}

Console.WriteLine("Enter file");
string fileName = Console.ReadLine();

Console.WriteLine("Enter file to start");
string directoryPath = Console.ReadLine();


DirectoryInfo root = new DirectoryInfo(directoryPath);
Find(fileName, root);

