using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gallery.Models;
using Gallery.Utility;
using Gallery.Service;
namespace Gallery.Controllers
{
    public class GalleryController : ApiController
    {
        [HttpGet]
        [Route("getGallery")]
        public Response getTodoList(string artist, string name, string attribute, string year, int page)
        {
            //string name,string author,string century,string attribute
            ServiceProvider service = new ServiceProvider();
            return service.selectResult(artist, name, attribute, year, page);
        }
    }
}