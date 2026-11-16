using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTI_Lucas_van_Hauwaert_POO_ACT3_Lampe
{
    internal class Lampe
    {
        byte _id;
        bool _etat;
        string _couleur = "";

        public byte Id
        {
            get { return _id; }
        }

        public bool Etat
        {
            get { return _etat; }
        }

        public Lampe(byte id, string couleur)
        {
            _id = id;
            _etat = false;
            _couleur = couleur;
        }

        public void Allumer()
        {
            _etat = true;
        }

        public void Eteindre()
        {
            _etat = false;
        }

        public string AfficherEtat()
        {
            if(_etat == true)
            {
                return "La lampe est allumée";
            }
            else
            {
                return "La lampe est éteinte";
            }
        }
    }
}
