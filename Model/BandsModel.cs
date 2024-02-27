using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Model{
    [Table("tb_bands")]
    internal class BandsModel{
        
        [Column("id")]
        public int Id {get;set;}

        [Column("name")]
        [MaxLength(255)]
        public string? Name {get;set;}

        [Column("dt_registration")]
        public DateTime DtRegistration {get;set;} = DateTime.UtcNow;

        // Setting One band to many albums
        public ICollection<AlbumsModel>? Albums {get;} = new List<AlbumsModel>();

        // Setting One band to many songs
        public ICollection<SongsModel>? Musics {get;} = new List<SongsModel>();
    }
}