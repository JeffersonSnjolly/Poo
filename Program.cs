using System;
using ExemploPoo.Models;

namespace ExemploPoo{

    class Program{
        static void Main(string[] args){
            Aluno a = new Aluno();
            a.nome = "Aline";
            a.Idade = 12;
            a.Nota = 8;
            a.Apresentar();
            a.verifica();

            Professor p = new Professor();
            p.nome = "Carlos";
            p.Idade = 30;
            p.Salario = 3000;
            p.Apresentar();
            p.Pagamento();

            // valores Validos.
            // Retangulo r = new Retangulo();
            // r.DefiniMedidas(30,30);
            // System.Console.WriteLine($"Area {r.ObterArea()}");

            //  Retangulo r2 = new Retangulo();
            // r.DefiniMedidas(-200,20);
            // System.Console.WriteLine($"Area {r2.ObterArea()}");

            //Pessoa p1 = new Pessoa();

            //p1.Nome = "João";
           // p1.Idade = 25;

           // p1.Apresentar();
        }

    }
}