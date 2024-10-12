using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokTest.Classes
{
    public class FileHandler
    {
        private string _filePath;

        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }

        //Kopplad till Save()-metoden
        public void WriteToFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(text);
            }
        }

        public void WriteToFileEdit(int selectedContact, string editedText)
        {
            
        }

    }
}
