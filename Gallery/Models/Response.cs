using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class Response
    {
        public Boolean isSuccess { get; set; } = true;
        public int code { get; set; } = 200;
        public String messenge { get; set; } = "success";
        public object data { get; set; }
        public Response()
        {

        }
        public Response(object data)
        {
            this.data = data;
        }
    }
}