using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("espetaculo")]
    public partial class Espetaculo
    {
        public Espetaculo()
        {
            RegistaEspetaculos = new HashSet<RegistaEspetaculo>();
        }

        [Key]
        [Column("id_espetaculo")]
        public int IdEspetaculo { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("sinopse")]
        [StringLength(100)]
        public string Sinopse { get; set; }
        [Column("data_inicio", TypeName = "date")]
        public DateTime DataInicio { get; set; }
        [Column("data_fim", TypeName = "date")]
        public DateTime DataFim { get; set; }
        [Column("preco", TypeName = "money")]
        public int Preco { get; set; }

        [InverseProperty(nameof(RegistaEspetaculo.IdEspetaculoNavigation))]
        public virtual ICollection<RegistaEspetaculo> RegistaEspetaculos { get; set; }
    }
}
