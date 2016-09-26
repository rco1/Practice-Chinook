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
    [Table("Albums")]
    class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }

        //navigation properties for use by linq
        //these properties will be of tpre virtual
        //there are two types of navigation properties
        //properties that points to children use Icollection
        //Properties that points to parent use parent type
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual Artist Artists { get; set; }
    }
}
