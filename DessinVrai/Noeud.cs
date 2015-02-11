using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin
{
    public class Noeud
    {
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        public Size Taille
        {
            get { return taille; }
            set { taille = value; }
        }
        public int Epaisseur
        {
            get { return epaisseur; }
            set { epaisseur = value; }
        }
        public Color Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        public Rectangle Rectangle
        {
            get { return new Rectangle(position, taille); }
        }
        public Point Centre
        {
            get { return new Point(position.X + taille.Width / 2, position.Y + taille.Height / 2); }
        }
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        public Rectangle Rect
        {
            get { return new Rectangle(position, taille); }
        }

        private Color couleur;
        private int epaisseur;
        private string texte;

        private Point position;
        private Size taille;

        public Noeud(Point p, Size s, Color c, int e, string t)
        {
            p.Offset(-s.Width / 2, -s.Height / 2);
            position = p;
            taille = s;
            couleur = c;
            epaisseur = e;
            texte = t;
        }

        public void dessine(Graphics g)
        {
            Pen p = new Pen(couleur, epaisseur);
            g.DrawRectangle(p, Rect);
            g.DrawString(texte, new Font("Tekton Pro", 12), Brushes.Azure, Centre);
        }

        public bool contient (Point p)
        {
            return Rectangle.Contains(p);
        }

        public void deplacer(Point p)
        {
            position.X = p.X - Rect.Width / 2;
            position.Y = p.Y - Rect.Height / 2;
        }
    }
}