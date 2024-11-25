using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Cadastro
{
    public class EstadoModel
    {
        [Key]
        public int IDESTADO { get; set; }

        [Required(ErrorMessage = "digite o Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "digite o Uf")]
        public string UF { get; set; }

        [Required(ErrorMessage = "digite o IBGE")]
        public int IBGE { get; set; }

        [Required(ErrorMessage = "digite o Pais")]
        public int IDPAIS { get; set; }

        [Required(ErrorMessage = "digite o DDD")]
        public string DDD { get; set; }

    }
}
