using System.ComponentModel.DataAnnotations;

namespace Vendas.Models.Cadastro
{
    public class ClienteModel
    {

        [Key]
        public int Idcliente { get; set; }

        [Required(ErrorMessage = "digite o Nome")]
        public string Nome { get; set; }

        public string Cnpj { get; set; }

        public string Cpf { get; set; }

        [Required(ErrorMessage = "digite o Rg")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "digite o Nomefantasia")]
        public string Nomefantasia { get; set; }

        [Required(ErrorMessage = "digite o Fisicajuridica")]
        public string Fisicajuridica { get; set; }

        [Required(ErrorMessage = "digite o Cfop")]
        public string Cfop { get; set; }

        [Required(ErrorMessage = "digite o Endereco")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "digite o Numero")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "digite o Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "digite o Idmunicipio")]
        public int Idmunicipio { get; set; }

        [Required(ErrorMessage = "digite o Idestado")]
        public int Idestado { get; set; }

        [Required(ErrorMessage = "digite o Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "digite o Idpais")]
        public int Idpais { get; set; }

        [Required(ErrorMessage = "digite o Zona")]
        public string Zona { get; set; }

        [Required(ErrorMessage = "digite o Regiao")]
        public string Regiao { get; set; }

        [Required(ErrorMessage = "digite o Setor")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "digite o Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "digite o Limitecredito")]
        public decimal Limitecredito { get; set; }

        [Required(ErrorMessage = "digite o Refcomercial")]
        public string Refcomercial { get; set; }

        [Required(ErrorMessage = "digite o Refpessoal")]
        public string Refpessoal { get; set; }

        [Required(ErrorMessage = "digite o Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "digite o Obs")]
        public string Obs { get; set; }

        [Required(ErrorMessage = "digite o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "digite o Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "digite o Idcondicopagamento")]
        public string Idcondicopagamento { get; set; }

        [Required(ErrorMessage = "digite o Idformapagamento")]
        public string Idformapagamento { get; set; }

        [Required(ErrorMessage = "digite o Valorminimo")]
        public decimal Valorminimo { get; set; }

        [Required(ErrorMessage = "digite o Cntrecdesp")]
        public string Cntrecdesp { get; set; }

        [Required(ErrorMessage = "digite o Ativo")]
        public string Ativo { get; set; }



    }
}
