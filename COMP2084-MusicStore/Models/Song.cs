using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_MusicStore.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }

        public String SongName { get; set; }

        public String ArtistName { get; set; }

        public String Featuring { get; set; }

        public int RunTimeSeconds { get; set; }

    }
}
