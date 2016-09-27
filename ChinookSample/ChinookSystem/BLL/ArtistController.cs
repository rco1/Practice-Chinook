using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.Data.Enitities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;

using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Artist> Artist_ListAll()
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }
        //report a dataset conaining data from 
        //multiple entities
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ArtistAlbums> ArtistAlbums_Get()
        {
            using (var context = new ChinookContext())
            {
                //you may also need to change your navgation 
                //refferencing  use in linqpad
                //to navigate properties you stated
                //in the entity class definition
                var results = from x in context.Albums
                              where x.ReleaseYear == 2008
                              orderby x.Artists.Name, x.Title
                              select new ArtistAlbums
                              
                              {
                                  Name = x.Artists.Name,
                                  Title = x.Title
                              };
                return results.ToList();
            }
        }
    }
}
