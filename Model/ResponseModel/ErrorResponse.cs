using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ResponseModel
{
    /*Class for Global Exception Handling*/
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public string Message;
    }
}
