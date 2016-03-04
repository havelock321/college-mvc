using System.ComponentModel;

namespace ExemploMVC02.Models
{
    public class Cliente
    {
        [DisplayName("Código: ")]
        public int FCLICOD { get; set; }

        [DisplayName("Nome: ")]
        public string FNOME { get; set; }
        [DisplayName("Endereço: ")]
        public string FENDERECO { get; set; }

        [DisplayName("CPF: ")]
        public string FCPF { get; set; }

    }

}