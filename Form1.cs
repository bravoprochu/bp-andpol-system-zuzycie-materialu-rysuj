using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuzycieMaterialu.Zuzycie;

namespace ZuzycieMaterialuRysuj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 110, Szerokosc = 50, Name = "nr1" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 40, Szerokosc = 40, Name = "nr2" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 250, Szerokosc = 20, Name = "nr3" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 110, Szerokosc = 5, Name = "nr4" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 170, Szerokosc = 110, Name = "nr5" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 100, Szerokosc = 10, Name = "nr6" });
            obszycia.Add(new ProstokatBaseClass() { Dlugosc = 210, Szerokosc = 95, Name = "nr7" });

            ProstokatParent pBaza = new ProstokatParent(1500, 120, obszycia);

            
        }



        Pen pen1 = new Pen(Color.Tomato,2) ;

        private List<ProstokatBaseClass> obszycia = new List<ProstokatBaseClass>();



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var item in obszycia)
            {
                g.DrawRectangle(pen1, new Rectangle(item.PosStartX, item.PosStartY, item.Dlugosc, item.Szerokosc));
            }

        }
    }
}
