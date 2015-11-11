using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace PatrickFuncties
{

     public class Persoon
     {
         private string voornaam;
         private string achternaam;
         private string geslacht;
         private Int32 leeftijd;
         public string gekregenVoornaam = voornaam;
         public string gekregenAchternaam = achternaam;
         public string gekregenGeslacht = geslacht;
         public string gekregenLeeftijd = leeftijd;
         public string VoorNaam
         {
             get
             {
                 return this.voornaam;
             }
             set
             {
                 this.voornaam = value;
             }
         }

         public string AchterNaam
         {
             get
             {
                 return this.achternaam;
             }
             set
             {
                 this.achternaam = value;
             }
         }

         public string Geslacht
         {
             get
             {
                 return this.geslacht;
             }
             set
             {
                 this.geslacht = value;
             }
         }

         public Int32 Leeftijd
         {
             get
             {
                 return this.leeftijd;
             }
             set
             {
                 this.leeftijd = value;
             }
         }


         public string Informatie
         {
             get
             {
                 return this.voornaam + " " + this.achternaam + ", " + this.leeftijd + " jaar oud. Geslacht: " + this.geslacht.ToString();
             }
         }
     }


    public class MijnFuncties
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">Waarde A: 1e waarde</param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32 TelBijElkaarOp (Int32 A, Int32 B)
        {
            return TelOp(A, B);

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">Waarde A: 1e waarde</param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32 TelBijElkaarOp(string strA, string strB)
        {
            Int32 iA = Int32.Parse(strA);
            Int32 iB = Int32.Parse(strB);

            return TelOp(iA, iB);
        }


        // Lokaal en niet publiekelijk benaderbaar
        private static Int32 TelOp(Int32 A, Int32 B)
        {
            return (A+B);
        }


    }


}
