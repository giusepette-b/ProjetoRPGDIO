using static System.Console;
namespace ProjetoRPGDIO
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Level { get; set; }

        public Personagem(string Nome, string Classe, int Level)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Level = Level;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public virtual string Attack()
        {
           return ($"O personagem {this.Nome} atacou usando sua espada"); 
        }

    }
}