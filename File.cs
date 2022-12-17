class File
{
    string folderPath=@"F:\C#\Dummy Folder"; //path of folder

    public void MakeFolder()  
    {
        Directory.CreateDirectory(folderPath+"\\FolderA");
    }

    // public void MakeFile()
    // {
    //       var fullFilePath = folderPath + @"\abc.cs";
    //     File.WriteAllText(fullFilePath, "This is first text file");
    // }

    // public void MakeFilesAndFolders()
    // {
    //     for(int i=0; i<=10; i++)
    //     {
    //         var folderName="Folder "+i;
    //         var folderPath=@$"F:\C#\Dummy Folder\{folderName}";
    //         Directory.CreateDirectory(folderPath);

    //         var filePath=folderPath+@"text.cs";
    //         File.WriteAllText(filePath, $"im in {folderName}");
    //     }
    // }

   
}