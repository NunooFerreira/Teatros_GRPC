using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("reserva")]
    public partial class Reserva
    {
        public Reserva()
        {
            ComprarBilhetes = new HashSet<ComprarBilhete>();
        }

        [Key]
        [Column("id_reserva")]
        public int IdReserva { get; set; }
        [Column("data_reserva", TypeName = "date")]
        public DateTime DataReserva { get; set; }
        [Column("quantidade")]
        public int Quantidade { get; set; }
        [Column("id_registo")]
        public int IdRegisto { get; set; }

        [ForeignKey(nameof(IdRegisto))]
        [InverseProperty(nameof(RegistaEspetaculo.Reservas))]
        public virtual RegistaEspetaculo IdRegistoNavigation { get; set; }
        [InverseProperty(nameof(ComprarBilhete.IdReservaNavigation))]
        public virtual ICollection<ComprarBilhete> ComprarBilhetes { get; set; }
    }
}
