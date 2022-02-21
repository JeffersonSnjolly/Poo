namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public void Pagamento(){
            if(Salario >= 4000){
                System.Console.WriteLine("Estou muito Feliz.");
            }else{
                System.Console.WriteLine("Estou muito triste.");
            }
        }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {nome} e meu salario é R${Salario}");
        }
    }
}