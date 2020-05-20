using System;
using System.Collections.Generic;
using System.Text;

namespace TP_03_lucas_barrozo_Csharp
{
    class Pessoa
    {
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        private DateTime Aniversario { get; }

        public Pessoa(String nome, String sobreNome, DateTime aniversario)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Aniversario = aniversario;
        }
        public int CalculaNiver() {
            DateTime hoje = DateTime.Today;
            DateTime proximoNiver = new DateTime(hoje.Year, Aniversario.Month, Aniversario.Day);

            if (proximoNiver < hoje)
            {
                proximoNiver = proximoNiver.AddYears(1);
            }

            int diasFaltantes = (proximoNiver - hoje).Days;

            return diasFaltantes;
        }

        public String toString()
        {
            return $"{Nome} {SobreNome} - {Aniversario}";
        }
    }
}
