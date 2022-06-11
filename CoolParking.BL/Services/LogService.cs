using CoolParking.BL.Interfaces;
using System;
using System.IO;
using System.Text;

public class LogService : ILogService
{


    public string LogPath { get; set; }


    public LogService(string logPath)
    {
        LogPath = logPath;
    }

    public string Read()
    {
        FileStream fs;
        StreamReader sr;
        string res;
        try
        {
            fs = new FileStream(LogPath, FileMode.Open);
            sr = new StreamReader(fs);
            res = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            return res;
        }
        catch(Exception ex)
        {
            throw new InvalidOperationException();
        }

    }

    public void Write(string logInfo)
    {
       using(FileStream fs = new FileStream(LogPath, FileMode.OpenOrCreate))
       {
            byte[] infoBytes = new UTF8Encoding(true).GetBytes(logInfo); 
            fs.Write(infoBytes, 0, infoBytes.Length);
       }
            
    }
}


// TODO: implement the LogService class from the ILogService interface.
//       One explicit requirement - for the read method, if the file is not found, an InvalidOperationException should be thrown
//       Other implementation details are up to you, they just have to rface requiremmatch the inteents
//       and tests, for example, in LogServiceTests you can find the necessary constructor format.
