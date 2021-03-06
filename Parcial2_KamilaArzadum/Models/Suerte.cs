using System.ComponentModel.DataAnnotations;

namespace Parcial2_KamilaArzadum.Models
{
    public class Suerte
    {
        [Key]

        public int SuerteId { get; set; }
        
        public string Detalle { get; set; }

        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        
        public string Imagen { get; set; }
    }
}
