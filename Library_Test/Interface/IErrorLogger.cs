using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Test.Interface
{
    public interface IErrorLogger
    {
        void WriteLog(Exception ex);
        void WriteActivity(string activity);
    }
}
