using System;
using ProjetoRPGDIO;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Wizard hero =  new Wizard("qualquer", "qualquer", 18);
        Personagem hero2 = new Personagem("mais um personagem", "da classe knight", 500);
        WriteLine(hero.Nome.ToString());
        WriteLine(hero.Attack());
        WriteLine(hero2.Attack());
        WriteLine(hero.Attack(200));
    }
}