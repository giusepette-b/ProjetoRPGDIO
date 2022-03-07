namespace ProjetoRPGDIO
{
    public class Knight : Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Level { get; set; }

        public Knight(string Nome, string Classe, int Level) : base(Nome, Classe, Level)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Level = Level;
        }
        public virtual string Attack()
        {
           return ($"O personagem {this.Nome} atacou usando sua Espada de duas mãos"); 
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return ($"O personagem {this.Nome} atacou usando sua Espada de duas mãos, com o bonus físico de{Bonus}");
            }
            else{
                return ($"O personagem {this.Nome} não teve ataque efetivo");
            }
            
        }
    }
}