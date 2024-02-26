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
        public DateTime dtRegistration = DateTime.Now;
    }
}