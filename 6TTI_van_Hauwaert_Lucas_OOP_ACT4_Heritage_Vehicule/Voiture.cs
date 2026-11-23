using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_van_Hauwaert_Lucas_OOP_ACT4_Heritage_Vehicule
{
    internal class Voiture : Vehicule
    {
        string _motorisation;
        bool _gps;

        public Voiture (string motorisation, bool gps, string marque, string modele, string couleur, decimal prix) : base (marque, modele, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

    }
}
