using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _6TTI_van_Hauwaert_Lucas_OOP_ACT4_Heritage_Vehicule
{
    internal class Vehicule
    {
        string _modele;
        string _marque;
        string _couleur;
        decimal _prix;

        public Vehicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }

        public virtual string Affiche()
        {
            string info = "Vehicule de marque " + _marque + " et de modele " + _modele + " de couleur " + _couleur + " au prix de " + _prix + ".";

            return info;
        }
    }
}
