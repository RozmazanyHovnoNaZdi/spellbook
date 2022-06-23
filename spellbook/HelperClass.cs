using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBook
{
    internal class HelperClass
    {
        public Random generator = new Random();

        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            string[] PoleZeSouboru = obsahTxt.Split(";");

            return PoleZeSouboru;
        }
        public string VygenerujSpellname(string[] poleForma, string[] poleTypy)
        {
            int randomName = generator.Next(23);
            string spellJmeno = $"{poleForma[randomName]} {poleTypy[randomName]}";

            return spellJmeno;
        }
        public int VygenerujCislo(int max)
        {
            int nahodneCislo = generator.Next(max);

            return nahodneCislo;
        }
    }
}