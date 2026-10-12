using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Model
{
    [Table("Materials")]

    internal class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [Required(ErrorMessage = "Název materiálu je povinné pole.")]
        [StringLength(100, ErrorMessage = "Jméno nesmí být delší než 100 znaků.")]
        public string Name { get; set; } = "";

        [Range(0, int.MaxValue, ErrorMessage = "Pojistná zásoba musí být kladné číslo.")]
        public int SafetyStock { get; set; } = 0; //pojistná zásoba

        [Range(0, int.MaxValue, ErrorMessage = "Množství na paletu musí být kladné číslo.")]
        public int PalletCapacity { get; set; } = 0; //množství na paletu

        [Column(TypeName = "data")]
        public DateTime ReceoveOn (get; set; } = DateTime.Days; //Datum přijetí materiálu

    }
}
