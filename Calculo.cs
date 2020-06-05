namespace Polimorfismo2
{
    public class Calculo
    {
        public string CalcularVida(){
            return "Não houve nenhum calculo a ser aplicado";
        }
        public string CalcularVida(int vida){
             return "A vida cheia do jogador é "+vida;
        }

        public string CalcularVida(int vida, int escudo){
            return "A vida cheia do jogador com escudo é "+(vida+escudo);
        }

        public string CalcularVida(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }

    }
}