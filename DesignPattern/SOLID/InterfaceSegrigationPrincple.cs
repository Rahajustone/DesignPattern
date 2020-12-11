using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SOLID
{
    // Divide interface for each task or responsibilities
    class InterfaceSegrigationPrincple
    {
    }


    // Instead putting everything together
    // We create a anterface for specific task
    interface IFileServer
    {
        void SaveFile();
        void CutFile();

        // This should be here
        // void SendEmail();
    }

    interface IEmailService
    {
        void SendEmail();
    }

    public class FileServer : IFileServer
    {
        public void CutFile()
        {
            Console.WriteLine("Cut the File");
        }

        public void SaveFile()
        {
            Console.WriteLine("Save the file");
        }
    }

    public class FileController : IFileServer, IEmailService
    {
        public void CutFile()
        {
        }

        public void SaveFile()
        {
        }

        public void SendEmail()
        {
        }
    }
}
