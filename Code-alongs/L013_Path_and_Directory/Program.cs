
Console.WriteLine("*** Path ***\n");

Console.WriteLine($"Path.VolumeSeparatorChar => {Path.VolumeSeparatorChar}");
Console.WriteLine($"Path.DirectorySeparatorChar => {Path.DirectorySeparatorChar}\n");

string path = Path.Combine("c:", "users", "fredrik", "downloads", "music.mp3");
Console.WriteLine($"path = {path}\n");

// path = @"c:\users\fredrik\downloads\music.mp3";

Console.WriteLine($"Path.GetFileName(path) => {Path.GetFileName(path)}");
Console.WriteLine($"Path.GetFileNameWithoutExtension(path) => {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"Path.GetExtension(path) => {Path.GetExtension(path)}");
Console.WriteLine($"Path.GetDirectoryName(path) => {Path.GetDirectoryName(path)}");
Console.WriteLine($"Path.GetPathRoot(path) => {Path.GetPathRoot(path)}");
Console.WriteLine($"Path.GetFullPath(path) => {Path.GetFullPath(path)}");

Console.WriteLine($"\nPath.Exists(path) => {Path.Exists(path)}\n");


Console.WriteLine("\n*** Directory ***\n");

path = @"C:\Users\Fredrik\Documents\NEU25G";
Console.WriteLine($"path = {path}\n");

Console.WriteLine($"Directory.Exists(path) => {Directory.Exists(path)}");
Console.WriteLine($"Directory.GetDirectoryRoot(path) => {Directory.GetDirectoryRoot(path)}");
Console.WriteLine($"Directory.GetParent(path) => {Directory.GetParent(path)}\n");

Console.WriteLine("Subdirectories:");
foreach (string subdir in Directory.GetDirectories(path))
{
    Console.WriteLine(subdir);
}

Console.WriteLine("\nFiles:");
foreach (string filepath in Directory.GetFiles(path, "*.txt"))
{
    Console.WriteLine(Path.GetFileName(filepath));
}

string newPath = Path.Combine(path, "newFolder", "test", "csharp");
Console.WriteLine($"\ncreate folder: {newPath}\n");

Directory.CreateDirectory(newPath);

string removePath = Path.Combine(path, "newFolder");
Console.WriteLine($"\ndelete folder: {removePath}\n");

// Removes directory only if empty, otherwise throws exception:
Directory.Delete(removePath);

// WARNING: Removes directory and all subdirectories (and files) without asking.
// Directory.Delete(removePath, true);

