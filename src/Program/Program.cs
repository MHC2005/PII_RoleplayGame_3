using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard emi = new Wizard("Emily");
            emi.AddItem(book);
            Wizard maru = new Wizard("Mary");
            maru.AddItem(book);

            Dwarf mateito = new Dwarf("Mathew");
            Dwarf franco = new Dwarf("Frank");

            
            Console.WriteLine($"Mary attacks Mathew with ⚔️ {maru.AttackValue}");// maru ataca a mateo
            mateito.ReceiveAttack(maru.AttackValue);
            Console.WriteLine($"Mathew has ❤️  {mateito.Health}"); //el valor de salud de mateo
            
            
            Console.WriteLine($"Emily attacks Frank with ⚔️ {emi.AttackValue}");//emi ataca a franco
            franco.ReceiveAttack(emi.AttackValue);
            Console.WriteLine($"Frank has ❤️  {franco.Health}"); //el valor de salud de franco
            

            Console.WriteLine($"Frank attacks Mary with ⚔️ {franco.AttackValue}");//franco ataca a maru
            maru.ReceiveAttack(franco.AttackValue);
            Console.WriteLine($"Mary has ❤️  {maru.Health}"); //valor de salud de maru
            

            Console.WriteLine($"Mathew attacks Emily with ⚔️ {mateito.AttackValue}"); //mateito ataca a emi
            emi.ReceiveAttack(mateito.AttackValue);
            Console.WriteLine($"Emiliy has ❤️  {emi.Health}"); //valor de salud de emi
            

            mateito.Cure();

            Console.WriteLine($"Someone cured Mathew. Mathew now has ❤️  {mateito.Health}");

            Enemy lotso = new Enemy("Lotso", 100);
            Enemy sauron = new Enemy("Sauron", 120);
            Enemy ursula = new Enemy("Ursula", 180);
            Enemy yzma = new Enemy("Yzma", 200);

            Console.WriteLine($"Lotso's VP is {lotso.VP}"); // Imprimo el VP de Lotso
            Console.WriteLine($"Sauron's VP is {sauron.VP}"); // Imprimo el VP de Sauron
            Console.WriteLine($"Ursula's VP is {ursula.VP}"); // Imprimo el VP de Ursula
            Console.WriteLine($"Yzma's VP is {yzma.VP}"); // Imprimo el VP de Yzma

        }
    }
}

