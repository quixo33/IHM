using Dessin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessinVrai
{
    public partial class Dessin : Form
    {
        Noeud noeudCourant;

        Point pointCourant;

        Size tailleNoeudParDefaut;

        Color couleurNoeudParDefaut;
        Color couleurTraitParDefaut;
        
        List<Noeud> noeuds;
        List<Trait> traits;

        int epaisseurNoeudParDefaut;
        int epaisseurTraitParDefaut;
        
        bool enDeplacement;
        bool dessinTrait;
        
        string texteNoeudParDefaut;
        
        public Dessin()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            noeudCourant = null;

            pointCourant = Point.Empty;

            tailleNoeudParDefaut = new Size(20, 30);

            couleurNoeudParDefaut = Color.DeepPink;
            couleurTraitParDefaut = Color.Maroon;

            noeuds = new List<Noeud>();
            traits = new List<Trait>();
            
            epaisseurNoeudParDefaut = 3;
            epaisseurTraitParDefaut = 1;

            dessinTrait = false;
            enDeplacement = false;

            texteNoeudParDefaut = null;
            
        }

        private Noeud NoeudCourant(MouseEventArgs e)
        {
            foreach (Noeud re in noeuds)
            {
                if (re.contient(e.Location))
                {
                    return re;
                }
            }
            return null;
        }

        private Noeud NoeudParDefaut(Point pointNoeudParDefaut)
        {
            return new Noeud(pointNoeudParDefaut, tailleNoeudParDefaut, couleurNoeudParDefaut, epaisseurNoeudParDefaut, texteNoeudParDefaut);
        }

        private void Dessin_MouseDown(object sender, MouseEventArgs e)
        {
            noeudCourant = NoeudCourant(e);
            if (deplacement.Checked)
            {
                if (noeudCourant != null)
                {
                    enDeplacement = true;
                }
            }
            else
            {   
                if (noeudCourant == null)
                {
                    Noeud nouveauNoeud = NoeudParDefaut(e.Location);
                    noeuds.Add(nouveauNoeud);
                }
                else
                {
                    dessinTrait = true;
                }
            }
            Refresh();
        }

        private void Dessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (Noeud n in noeuds)
            {
                n.dessine(e.Graphics);
            }
            foreach (Trait t in traits)
            {
                t.dessine(e.Graphics);
            }
            if (pointCourant != Point.Empty)
            {
                Noeud fin = new Noeud(pointCourant, tailleNoeudParDefaut, Color.Black, epaisseurNoeudParDefaut, texteNoeudParDefaut);
                fin.dessine(e.Graphics);
                e.Graphics.DrawLine(Pens.LimeGreen, noeudCourant.Centre, pointCourant);
            }
        }

        private void Dessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (enDeplacement)
            {
                if (noeudCourant != null)
                {
                    noeudCourant.deplacer(e.Location);
                }
            }
            if (dessinTrait)
            {
                pointCourant = e.Location;
            }
            Refresh();
        }

        private void Dessin_MouseUp(object sender, MouseEventArgs e)
        {
            enDeplacement = false;
            if(dessinTrait)
            {
                Noeud fin = NoeudCourant(e);
                if (fin == null)
                {
                    fin = new Noeud(e.Location, tailleNoeudParDefaut, couleurNoeudParDefaut, epaisseurNoeudParDefaut, texteNoeudParDefaut);
                    noeuds.Add(fin);
                }
                Trait trait = new Trait(noeudCourant, fin, couleurTraitParDefaut, epaisseurTraitParDefaut);
                traits.Add(trait);
                Refresh();
                dessinTrait = false;
            }
            noeudCourant = null;
            pointCourant = Point.Empty;
        }
    }
}
