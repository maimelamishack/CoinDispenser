using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDispenser.Models
{
    //Defining a model annotated to name the Table that will be generated in database during the Migration Update
    [Table("CoinDispense")]
    public class CoinDenomination
    {
        //Unique ID gerenator to uniquely identify each entry
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoinDenominationId { get; set; }

        public int V1 { get; set; }

        public int V2 { get; set; }

        public int V3 { get; set; }

        public int V4 { get; set; }

        public int V5 { get; set; }

        public int V6 { get; set; }

        public int V7 { get; set; }

        public int V8 { get; set; }
        public int V9 { get; set; }
    }
}
