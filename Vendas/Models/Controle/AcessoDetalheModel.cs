using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Controle
{
    public class AcessoDetalheModel
    {

        [Required(ErrorMessage = "digite o Idcolaborador")]
        public int Idcolaborador { get; set; }
        [Required(ErrorMessage = "digite o Acesso")]
        public int Acesso { get; set; }
        [Required(ErrorMessage = "digite o Incluir")]
        public int Incluir { get; set; }
        [Required(ErrorMessage = "digite o Alterar")]
        public int Alterar { get; set; }
        [Required(ErrorMessage = "digite o Excluir")]
        public int Excluir { get; set; }
        [Required(ErrorMessage = "digite o Listar")]
        public string Listar { get; set; }
        [Required(ErrorMessage = "digite o Atvenda")]
        public string Atvenda { get; set; }
        [Required(ErrorMessage = "digite o Atbrinde")]
        public string Atbrinde { get; set; }
        [Required(ErrorMessage = "digite o Atdesconto")]
        public string Atdesconto { get; set; }



    }
}
