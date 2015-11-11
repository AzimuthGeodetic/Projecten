using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatrickFuncties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            /* DEBUG */
         
            Persoon p = new Persoon();
            p.VoorNaam = "Patrick";
            p.AchterNaam = "Schut";
            p.Geslacht = "Man";
            p.Leeftijd = 17;

            /* EINDE DEBUG */
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {

            /* OUDE TEST CODE */

            //Int32 value = Int32.Parse(tb1.Text);
            //Int32 value2 = Int32.Parse(tb2.Text);
            //Int32 value3 = value + value2;

            //Int32 DeSom = PatrickFuncties.MijnFuncties.TelBijElkaarOp(tb1.Text, tb2.Text);

            //string melding = (String.Format("De som van {0} en {1} = {2}", tb1.Text, tb2.Text, DeSom));
            //MessageBox.Show(melding, "Melding", MessageBoxButtons.OK);

            /* EIND OUDE TEST CODE */

            string NaamFilter = tb1.Text;

            Persoon p = new Persoon();
            p.VoorNaam = p.gekregenVoornaam;
            p.AchterNaam = p.gekregenAchternaam;
            p.Geslacht = p.gekregenGeslacht;
            p.Leeftijd = p.gekregenLeeftijd;
            MessageBox.Show(p.Informatie, p.VoorNaam + " " + p.AchterNaam, MessageBoxButtons.OK);
      
        }


    }
}
