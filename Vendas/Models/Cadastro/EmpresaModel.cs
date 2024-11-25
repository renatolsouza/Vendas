using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Cadastro
{
    public class EmpresaModel
    {

        [Key]
        public int Idempresa { get; set; }

        [Required(ErrorMessage = "digite o Nome")]
        public string Nome { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime Dtcadastro { get; set; }

        [Required(ErrorMessage = "digite o Endereco")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "digite o Numero")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "digite o Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "digite o Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "digite o Municipio")]
        public int Idmunicipio { get; set; }

        [Required(ErrorMessage = "digite o Pais")]
        public int Idpais { get; set; }

        [Required(ErrorMessage = "digite o Estado")]
        public int Idestado { get; set; }

        [Required(ErrorMessage = "digite o Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "digite o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "digite o Cnpj")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "digite o Inscestadual")]
        public string Inscestadual { get; set; }

        [Required(ErrorMessage = "digite o Inscmunicipal")]
        public string Inscmunicipal { get; set; }

        [Required(ErrorMessage = "digite o Titular")]
        public string Titular { get; set; }

        [Required(ErrorMessage = "digite o Nomefantasia")]
        public string Nomefantasia { get; set; }

        [Required(ErrorMessage = "digite o Cnae")]
        public string Cnae { get; set; }

        [Required(ErrorMessage = "digite o Situacaofiscal")]
        public string Situacaofiscal { get; set; }

        [Required(ErrorMessage = "digite o Crt")]
        public string Crt { get; set; }

        [Required(ErrorMessage = "digite o Aliquotaicms")]
        public string Aliquotaicms { get; set; }

        public string Incluidopor { get; set; }

        public DateTime Datainclusao { get; set; }

        public string Editadopor { get; set; }

        public DateTime Dataedicao { get; set; }

        [Required(ErrorMessage = "digite o Ativo")]
        public string Ativo { get; set; }


    }
}
