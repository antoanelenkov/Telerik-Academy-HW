using MusicSystem.Data;
using MusicSystem.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers.MyControllers
{
    public class BaseController : ApiController
    {
        protected IMusicSystemData Db { get; set; }

        public BaseController() : this(new MusicSystemData())
        {
        }

        public BaseController(IMusicSystemData db)
        {
            this.Db = db;
        }
    }
}