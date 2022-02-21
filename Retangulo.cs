namespace ExemploPoo.Models
{
    public class Retangulo
    {
        private double Comprimento { get; set; }
        private double Altura { get; set; }
        private bool Valido;
        public void DefiniMedidas(double Comprimento, double Altura){
            if(Comprimento > 0 && Altura > 0){
            this.Comprimento = Comprimento;
            this.Altura = Altura;
            Valido = true;
            }else{
                System.Console.WriteLine("Valores Invalidos");
            }  
        }
        public double ObterArea(){
            if(Valido == true){
            return Comprimento * Altura;
            }else{
                System.Console.WriteLine("Esse Valor não é valido");
                return 0;
            }

        }

    }
}