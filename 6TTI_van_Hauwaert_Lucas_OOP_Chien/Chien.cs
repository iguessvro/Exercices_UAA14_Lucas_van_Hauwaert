using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_van_Hauwaert_Lucas_OOP_Chien
{
    internal class Chien
    {
        string _nom;
        string _age;
        string _race;
        string _dateNaissance;
        string _numeroPuce;
        string _carnetSante;

        public Chien (string nom, string race)
        {
            _nom = nom;
            _race = race;
        }
        public void Vacciner(string nomVaccin)
        {
            _carnetSante = nomVaccin;
        }
        public string InfoChien()
        {
            return "Mon chien s'appelle " + _nom + "et est un " + _race;
        }
    }
}
