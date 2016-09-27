using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Enitities;
#endregion

namespace ChinookSystem.DAL
{
    //internal for security reason
    //access restricted to within the component library
    //inherit Db context for entity framework requires
    // system.data.entity
    internal class ChinookContext:DbContext
    {
        //pass the connection string name to the
        //db context using :base
        public ChinookContext():base("ChinookDB")
        {

        }
        //setupDBset
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
    }
}
