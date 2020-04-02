using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Library_Test.Interface;

namespace Library_Test.Helpers
{
    public class ErrorLogger : IErrorLogger
    {
        private readonly string _destFolder;
        public ErrorLogger(IHostingEnvironment env)
        {
            _destFolder = Path.Combine(env.ContentRootPath, "ErrorLogs");
            try
            {
                if (!Directory.Exists(_destFolder)) Directory.CreateDirectory(_destFolder);
            }
            catch (Exception)
            {
            }

        }

        public void WriteLog(Exception ex)
        {
            try
            {
                if (ex.Message == "Thread was being aborted.") return;

                var file = Path.Combine(_destFolder, $"{DateTime.Now.ToString("dd_MM_yyy_")}ErrorLog.txt");
                bool hasInnerException = false;

                using (var writer = new StreamWriter(file, true))
                {
                    writer.WriteLine($"========================{ DateTime.Now.ToString()}==========================");
                    writer.WriteLine($"---------- ex------------");
                    writer.WriteLine(ex);
                    writer.WriteLine($"---------- Message------------");
                    writer.WriteLine(ex.Message);

                    writer.WriteLine($"---------- Stack Trace------------");
                    writer.WriteLine(ex.StackTrace);

                    if (ex.InnerException != null)
                    {
                        hasInnerException = true;
                        writer.WriteLine($"************ Inner Exception ************");
                    }
                    if (hasInnerException) WriteLog(ex.InnerException);
                }
            }
            catch (Exception)
            {
            }
        }

        public void WriteActivity(string activity)
        {
            try
            {
                var file = Path.Combine(_destFolder, $"{DateTime.Now.ToString("dd_MM_yyyy_")}ActivityLog.txt");
                using (var writer = new StreamWriter(file, true))
                {
                    writer.WriteLine($"========={DateTime.Now}=========");
                    writer.WriteLine(activity);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
