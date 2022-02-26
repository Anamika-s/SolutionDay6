using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay6
{
    class CustomException : Exception
    {
        public string Message { get; set; }
        public CustomException(string Message) : base(Message)
        {
            this.Message = Message;
        }
    }
}
