using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("regista_espetaculo")]
    public partial class RegistaEspetaculo
    {
        public RegistaEspetaculo()
        {
            Reservas = new HashSet<Reserva>();
        }

        [Key]
        [Column("id_registo")]
        public int IdRegisto { get; set; }
        [Column("id_sessao")]
        public int IdSessao { get; set; }
        [Column("id_espetaculo")]
        public int IdEspetaculo { get; set; }
        [Column("id_teatro")]
        public int IdTeatro { get; set; }

        [ForeignKey(nameof(IdEspetaculo))]
        [InverseProperty(nameof(Espetaculo.RegistaEspetaculos))]
        public virtual Espetaculo IdEspetaculoNavigation { get; set; }
        [ForeignKey(nameof(IdSessao))]
        [InverseProperty(nameof(Sessao.RegistaEspetaculos))]
        public virtual Sessao IdSessaoNavigation { get; set; }
        [ForeignKey(nameof(IdTeatro))]
        [InverseProperty(nameof(Teatro.RegistaEspetaculos))]
        public virtual Teatro IdTeatroNavigation { get; set; }
        [InverseProperty(nameof(Reserva.IdRegistoNavigation))]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
