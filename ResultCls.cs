using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPI
{
    public class ResultCls
    {
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
