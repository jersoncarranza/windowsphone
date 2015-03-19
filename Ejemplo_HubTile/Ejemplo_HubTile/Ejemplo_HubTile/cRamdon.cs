using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_HubTile
{
    public class cRamdon
    {
        string var;
        public int choose_picture(int ps)
        {
            Random Esc_pic = new Random();
            int pes= Esc_pic.Next(1,ps);
            
            return pes;
        }

        public string word_picture(int np)
        {
           
            switch (np)
            {
                case 1:
                     var = "Bebe";
                    break;
                case 2:
                    var = "Carro";
                    break;
                case 3:
                    var = "Colibri";
                    break;
                case 4:
                    var = "Fuego";
                    break;
                case 5:
                    var = "Guitarra";
                    break;
                case 6:
                    var = "Leche";
                    break;
                case 7:
                    var = "Luna";
                    break;
                case 8:
                    var = "Número";
                    break;
                case 9:
                    var = "Sol";
                    break;
                case 10:
                    var = "Oso";
                    break;
                case 11:
                    var = "Volcan";
                    break;
                case 12:
                    var = "Abecedario";
                    break;


            }

            return var;
        }



    }
}
