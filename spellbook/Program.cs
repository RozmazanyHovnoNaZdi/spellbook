global using SpellBook;


Console.WriteLine("Generátor náhodných spellů");
List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();
Spell Spell = new Spell();
string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");

while (true)
{
    Console.WriteLine("1. Vygenerovat nový spell a přidat do Spellbooku");
    Console.WriteLine("2. Zobrazit Spellbook");
    Console.WriteLine("3. Smazat poslední záznam ve Spellbooku");
    Console.WriteLine("4. Smazat celý Spellbook");
    Console.WriteLine(". Ukončit aplikaci");
    string input = Console.ReadLine();
    Console.Clear();




    if (input == "1")
    {
        Spell newSpell = new Spell();

        newSpell.Name = pomocneMetody.VygenerujSpellname(poleForma, poleTypy);

        newSpell.ManaCost = pomocneMetody.VygenerujCislo(100);

        seznamSpellu.Add(newSpell);

        Console.Clear();
    }





    else if (input == "2")
    {
        foreach (var spell in seznamSpellu)
        {

            Console.WriteLine($"Spell: {spell.Name}    Mana za spell: {spell.ManaCost}");
        }
    }





    else if (input == "3")
    {


        int indexPosledniho = seznamSpellu.Count - 1;

        Spell posledni = seznamSpellu[indexPosledniho];

        seznamSpellu.Remove(posledni);

        Console.Clear();
    }




    else if (input == "4")
    {
        seznamSpellu.Clear();

        Console.Clear();
    }







    else if (input == "")
    {
        break;
    }
}