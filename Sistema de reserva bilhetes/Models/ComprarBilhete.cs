using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("comprar_bilhete")]
    public partial class ComprarBilhete
    {
        [Key]
        [Column("id_compra")]
        public int IdCompra { get; set; }
        [Column("id_utilizador")]
        public int IdUtilizador { get; set; }
        [Column("id_reserva")]
        public int IdReserva { get; set; }
        [Column("total_pagar", TypeName = "money")]
        public int TotalPagar { get; set; }
        [Column("referencia_pagamento")]
        public int ReferenciaPagamento { get; set; }

        [ForeignKey(nameof(IdReserva))]
        [InverseProperty(nameof(Reserva.ComprarBilhetes))]
        public virtual Reserva IdReservaNavigation { get; set; }
        [ForeignKey(nameof(IdUtilizador))]
        [InverseProperty(nameof(Utilizador.ComprarBilhetes))]
        public virtual Utilizador IdUtilizadorNavigation { get; set; }
    }
}
