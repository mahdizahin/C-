using System;


namespace FileUse.File
{
    public class FirstClass
    {
        string fileName;
        int fileId;

        public FirstClass(string fileName, int fileId)
        {
            this.fileName = fileName;
            this.fileId = fileId;
        }

       public void display()
        {
            Console.WriteLine("File Name : "+fileName); 
            Console.WriteLine("File Id : " +fileId);
        }
    }
}
