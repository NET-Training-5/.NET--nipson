class Lion: Animal, Kings
{
    public void CreateDirectoriesAndFiles()
    {   
        for(int i=0; i<=10; i++)
        {
            var folderName="Folder "+i;
            var folderPath=@$"F:\C#\abcde\{folderName}";
            Directory.CreateDirectory(folderPath);

       
        }
    }
}