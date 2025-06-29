using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; } 
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public T Data { get; set; }
        public List<string>Errors { get; set; }
        //public Dictionary<string, List<string>> ErrorsBag { get; set; }

        public object Meta { get; set; }

        public Response()
        {
            
        }
        public Response(T data,string message=null)
        {
            Data = data;
            Message = message;
            Succeeded = true;
        }
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }
        public Response(string message,bool succeeded)
        {
            Message = message;
            Succeeded = succeeded;
        }
    }
}
