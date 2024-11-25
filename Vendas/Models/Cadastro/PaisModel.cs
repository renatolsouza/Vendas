using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Cadastro
{
    public class PaisModel
    {

        [Key]
        public int IDPAIS { get; set; }

        [Required(ErrorMessage = "digite o Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "digite o Nome_pt")]
        public string NOME_PT { get; set; }

        [Required(ErrorMessage = "digite o Sigla")]
        public string SIGLA { get; set; }

        [Required(ErrorMessage = "digite o Bacen")]
        public int BACEN { get; set; }


    }
}
