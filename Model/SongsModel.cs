
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ScreenSound.Model{
    [Table("tb_songs")]
    internal class SongsModel{

        [Column("id")]
        public int Id {get;set;}

        [Column("name")]
        [NotNull]
        [MaxLength(255)]
        public string? Name {get;set;}

        // Band Id
        [Column("band_id")]
        [ForeignKey("BandId")]
        public int BandId {get;set;}
        public BandsModel? Band {get;set;} = null!;

        //Album Id
        [Column("album_id")]
        [ForeignKey("AlbumId")]
        public int AlbumId {get;set;}
        public AlbumsModel? Album {get;set;} = null!;
    }
}