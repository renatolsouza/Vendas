using Vendas.Models.Cadastro;

namespace Vendas.DTOs
{
    public class CidadeDto
    {
        public int IDCIDADE { get; set; }
        public string NOME { get; set; }
        public int Uf { get; set; }
        public string NOMEUF { get; set; }
        public int IBGE { get; set; }
        public List<EstadoDto> EstadoList { set; get; }
    }
}
