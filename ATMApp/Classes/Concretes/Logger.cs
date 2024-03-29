using System;
using System.IO;
using System.Text;

namespace ATMApp;

class Logger
{
    static string folderName = "Logs";
    static string root = $"{Environment.CurrentDirectory}\\{typeof(Logger).Namespace}\\{folderName}";
    static string path;
    static DateTime time;

    public static void FileLogMessage(string log)
    {
        CreateDirectory();
        FileLog(string.Format("[{0}] {1}", time.ToString("dd.MM.yyyy HH:mm:ss"), log));
    }

    public static void FileLogSuccessTransaction(Transaction transaction, double amount)
    {
        CreateDirectory();
        FileLog(string.Format("[{0}] {1}: {2}.", time.ToString("dd.MM.yyyy HH:mm:ss"), transaction, amount));
    }

    public static void FileLogFailureTransaction(string log, Transaction transaction)
    {
        CreateDirectory();
        FileLog(string.Format("[{0}] {1}: {2}", time.ToString("dd.MM.yyyy HH:mm:ss"), transaction, log));
    }

    static void FileLog(string log)
    {
        using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
        {
            UTF8Encoding unicode = new UTF8Encoding();
            byte[] text = unicode.GetBytes(log);
            fs.Flush();
            fs.Write(text);
            fs.Flush();
        }
    }

    static void CreateDirectory()
    {
        time = DateTime.Now;
        string directory = $"{root}\\{time.Year}\\{time.ToString("MMMM")}\\{time.ToString("dd")}";
        path = $"{directory}\\EOD_{time.ToString("yyyyMMdd")}.txt";
        Directory.CreateDirectory(directory);
    }
}