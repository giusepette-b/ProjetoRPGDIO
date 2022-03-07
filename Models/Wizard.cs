using static System.Console;
namespace ProjetoRPGDIO
{
    class Wizard : Personagem
    {      
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Level { get; set; }

        public Wizard(string Nome, string Classe, int Level) : base(Nome, Classe, Level)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Level = Level;
        }
        public virtual string Attack()
        {
           return ($"O personagem {this.Nome} atacou usando sua magia"); 
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return ($"O personagem {this.Nome} atacou usando sua magia, com o bonus mágico de{Bonus}");
            }
            else{
                return ($"O personagem {this.Nome} não teve ataque efetivo");
            }
            
        }
    }
}