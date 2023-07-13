using System;
using System.IO;
namespace bucinakalkulacka.components
{
    public class ErrorProvider
    {
        public void SendError(Exception ex)
        {
            Console.WriteLine($"chyba {ex}");
            logError(ex);
        }
        private void logError(Exception ex)
        {
            string filePath = "..\\log.txt";

            if (!File.Exists(filePath))
            {
                using (FileStream fileStream = File.Create(filePath))
                {                    
                    fileStream.Close();
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                DateTime now = DateTime.Now;
                writer.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteLine(ex);
            }
        }
    }
}
