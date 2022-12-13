using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gallery.Models;
using Gallery.Utility;

namespace Gallery.Controllers
{
    public class GalleryController : ApiController
    {
        [HttpGet]
        [Route("getGallery")]
        public Response getTodoList(string artist,string name,string attribute,string year)
        {
            String sqlcmd = "";
            if (year == null)
            {
                sqlcmd = $"SELECT * FROM gallery_table WHERE artist LIKE '%{artist}%' AND drawName LIKE '%{name}%' AND attribute LIKE '%{attribute}%'";
            }
            else
            {
                int centuryStart = int.Parse(year)-1;
                sqlcmd = $"SELECT * FROM gallery_table WHERE artist LIKE '%{artist}%' AND drawName LIKE '%{name}%' AND attribute LIKE '%{attribute}%' AND startYear BETWEEN {centuryStart * 100} AND {centuryStart * 100 + 99}";
            }
            //string name,string author,string century,string attribute
            Database database = new Database(sqlcmd);
            return database.selector();
        }
    }
}