using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_van_Hauwaert_Lucas_OOP_ACT4_Heritage_Vehicule
{
    internal class Velo : Vehicule
    {
        string _type;
        bool _estElectrique;

        public Velo (string type, bool estElectrique, string marque, string modele, string couleur, decimal prix) : base (marque, modele, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

    }
}
