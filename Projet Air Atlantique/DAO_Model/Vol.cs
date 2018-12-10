﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Models.DAO
{
    class Vol
    {
       // idVol reference   departPrevu arriveePrevue   departEffectif arriveeEffective    etat

        private int IdVol;
        private string Reference;
        private DateTime DepartPrevu;
        private DateTime ArriveePrevue;
        private DateTime DepartEffectif;
        private DateTime ArriveeEffective;
        private string Etat;

        public Vol() { }

        public Vol(int IdVol, string Reference, DateTime DepartPrevu, DateTime ArriveePrevue, DateTime DepartEffectif, DateTime ArriveeEffective, string Etat)
        {
            this.IdVol = IdVol;
            this.Reference = Reference;
            this.DepartPrevu = DepartPrevu;
            this.ArriveePrevue = ArriveePrevue;
            this.DepartEffectif = DepartEffectif;
            this.ArriveeEffective = ArriveeEffective;
            this.Etat = Etat;

        }

        public string ReferenceProperty
        {
            get { return Reference; }
            set { Reference = value; }
        }

        public DateTime DepartPrevuProperty
        {
            get { return DepartPrevu; }
            set { DepartPrevu = value; }
        }

        public DateTime ArriveePrevueProperty
        {
            get { return ArriveePrevue; }
            set { ArriveePrevue = value; }
        }

        public DateTime DepartEffectifProperty
        {
            get { return DepartEffectif; }
            set { DepartEffectif = value; }
        }

        public DateTime ArriveeEffectiveProperty
        {
            get { return ArriveeEffective; }
            set { ArriveeEffective = value; }
        }

        public string EtatProperty
        {
            get { return Etat; }
            set { Etat = value; }
        }
    }
}
