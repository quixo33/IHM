using Dessin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessinVrai
{
    public class Trait
    {
        public Noeud Source
        {
            get { return source; }
            set { source = value;  }
        }

        public Noeud Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        private Noeud source;
        private Noeud destination;
        private Color couleur;
        private int epaisseur;

        public Trait(Noeud sour, Noeud dest, Color c, int e)
        {
            source = sour;
            destination = dest;
            couleur = c;
            epaisseur = e;
        }

        public void dessine(Graphics g)
        {
            Pen p = new Pen(couleur, epaisseur);
            g.DrawLine(p,source.Centre,destination.Centre);
        }

    }
}
