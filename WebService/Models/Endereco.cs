using System;

namespace WebService.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Localidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
