namespace ExemploPoo.Models

{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public void verifica(){
            if(Nota > 6){
                System.Console.WriteLine("Aprovado");
            }else{
                System.Console.WriteLine("Reprovado");
            }
        }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá eu so o aluno {nome} e minha nota é {Nota}");
        }
    
    }
}