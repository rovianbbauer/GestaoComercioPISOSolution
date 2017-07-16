using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoComercioPISO.WebSite.Models
{
    [Table("ClienteRovian")]
    public partial class ClienteRovian
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(255)]
        public String NomeCompletoRazaoSocial { get; set; }
        [StringLength(255)]
        public String ApelidoNomeFantasia { get;set;}
        [Required]
        [StringLength(15)]
        public String CPFCNPJ { get; set; }

        
    }
}