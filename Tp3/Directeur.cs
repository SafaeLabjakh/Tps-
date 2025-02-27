﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Directeur : Personnel
    {
        private static Directeur instance;

        private Directeur(int code, string nom, string prenom, string bureau, double salaire, double prime)
                : base(code, nom, prenom, bureau,salaire,prime)
        {
        }
        public static Directeur GetInstance(int code, string nom, string prenom, string bureau,double salaire, double prime)
        {
            if (instance == null)
            {
                instance = new Directeur(code, nom, prenom, bureau,salaire,prime);
            }
            else
            {
                Console.WriteLine("Erreur : Un seul directeur peut être créé.");
            }
            return instance;
        }


        public override double Calculer_Salaire()
        {
            return Salaire + Prime;
        }
    }

}
