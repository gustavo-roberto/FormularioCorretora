using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FormularioCorretora.Models
{
    public class FormularioCorretoraModel
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int Idade { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Banco { get; set; }
        [Display(Name = "Conta Corrente")]
        public int ContaCorrente { get; set; }

        [Display(Name="Dígito")]
        public int Digito { get; set; }
        public int Agencia { get; set; }
        public int Vecimento { get; set; }

        [Display(Name = "Código de Segurança")]
        public int CodigoSeguranca { get; set; }
    }
}