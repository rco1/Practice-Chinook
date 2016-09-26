using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChinookSystem.Data.Enitities
{
    //point to the sql table that this file maps
    [Table("Artists")]
    public class Artist
    {
        //key notation is ptional if the sql pkey ends in ID or Id
        //required if default of entity is not identity
        //requires if pkey is compound
        //properties can be fully implemented or
        //auto implemented
        //property names should use sql attribute name
        //properties should be listed in the same ordr
        // as sql table attributes or easy of maintenance
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }

        //navigation properties for use by linq
        //these properties will be of tpre virtual
        //there are two types of navigation properties
        //properties that points to children use Icollection
        //Properties that points to parent use parent type

        public virtual ICollection<Album> Albums { get; set; }

    }
}
