using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Videobutik.Models;

namespace Videobutik.Context
{
    public class VideofilmContext:DbContext
    {
        public DbSet<Videofilm> Videofilmer { get; set; }
    }
}