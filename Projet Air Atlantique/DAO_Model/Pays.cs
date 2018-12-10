﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.DAO_Model
{
    class Pays
    {
        private int IdPays;
        private string Libelle;

        public Pays() { }

        public Pays(int IdPays, string Libelle)
        {
            this.IdPays = IdPays;
            this.Libelle = Libelle;
        }

        public int IdPaysProperty
        {
            get { return IdPays; }
            set { IdPays = value; }
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }
    }
}
