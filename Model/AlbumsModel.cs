using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace ScreenSound.Model{
    [Table("tb_albums")]
    internal class AlbumsModel{
        
        [Column("id")]
        public int Id {get;set;}

        [Column("name")]
        [MaxLength(255)]
        public string? Name {get;set;}

        [Column("band_id")]
        [ForeignKey("BandId")]
        public int? BandId {get;set;}

        public BandsModel? Band {get;set;} = null!;
    }
}