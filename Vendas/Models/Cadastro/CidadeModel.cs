using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Cadastro
{
    public class CidadeModel
    {
        [Key]
        public int IDCIDADE { get; set; }

        [Required(ErrorMessage = "digite o Descricao")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "digite o Uf")]
        public int Uf { get; set; }

        [Required(ErrorMessage = "digite O IBGE")]
        public int IBGE { get; set; }

    }

   
}
