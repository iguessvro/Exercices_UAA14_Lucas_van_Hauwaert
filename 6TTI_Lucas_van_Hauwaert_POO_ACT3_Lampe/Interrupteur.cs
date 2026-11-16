using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _6TTI_Lucas_van_Hauwaert_POO_ACT3_Lampe
{
    internal class Interrupteur
    {
        byte _id;
        Lampe _lampeLiee;

        public byte Id
        {
            get { return _id; }
        }

        public Lampe LampeLiee
        {
            get { return _lampeLiee;  }
            set { _lampeLiee = value; }
        }

        public Interrupteur(byte id, Lampe lampeLiee)
        {
            _id = id;
            _lampeLiee = lampeLiee;
        }

        public void Actionner()
        {
            if (_lampeLiee.Etat == false)
            {
                _lampeLiee.Etat = true;
            }
        }
    }
}
