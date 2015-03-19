using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace Ejemplo_HubTile
{
    public partial class Pastas : PhoneApplicationPage
    {
        int res_pic;
        int num_ima=13;
        cRamdon obj = new cRamdon();

        int res_pos;//posicion que esta la imagenes 
        int pos_real;//posicion real
        public Pastas()
        {
            InitializeComponent();
           // num_ima = 11;
        }

        private void text_blok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            Animacion.Stop();
            Animacion.Begin();
            //le vaciamos 
            empty();
            //llenamos imagenes falsas

            p1.Visibility = Visibility.Visible;
            p2.Visibility = Visibility.Visible;
            p3.Visibility = Visibility.Visible;
            p4.Visibility = Visibility.Visible;

        

            llenarRamdonImagenFalsas();
            llenarRamdonImagenFalsas();
            llenarRamdonImagenFalsas();
          
            //llenamos con ramdon la verdadera
            llenarRamdonImagen();

            //llenarRamdonImagenFalsas()
          ///  llenar_posicioncarro();
             pos_real = res_pos;
          

        }

        void empty()
        {
            BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS", UriKind.Relative));
            p1.Source = imgSource1;
            BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS", UriKind.Relative));
            p2.Source = imgSource2;
            BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS", UriKind.Relative));
            p3.Source = imgSource3;
            BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS", UriKind.Relative));
            p4.Source = imgSource4;
     
        }

        void llenarRamdonImagen()
        {
             
            //Escoje la imagen 
           res_pic = obj.choose_picture(13);

           
            switch (res_pic)
            {
                case 1:
                    txt_nombre.Text = "Bebe";
                    llenar_posicionbebe();
                 break;
                case 2:
                    txt_nombre.Text = "Carro";
                    llenar_posicioncarro();
                    break;
                case 3:
                    txt_nombre.Text = "Colibri";
                    llenar_posicioncolibri();
                    break;
                case 4:
                    txt_nombre.Text = "Fuego";
                    llenar_posicionfuego();
                    break;
                case 5:
                    txt_nombre.Text = "Guitarra";
                    llenar_posicionguitarra();
                    break;
                case 6:
                    txt_nombre.Text = "Leche";
                    llenar_posicionleche();
                    break;
                case 7:
                    txt_nombre.Text = "Luna";
                    llenar_posicionluna();
                    break;
                case 8:
                    txt_nombre.Text = "Numeros";
                    llenar_posicionnumero();
                    break;
                case 9:
                    txt_nombre.Text = "Oso";
                    llenar_posicionoso();
                    break;
                case 10:
                    txt_nombre.Text = "Sol";
                    llenar_posicionsol();
                    break;
                case 11:
                    txt_nombre.Text = "Volcan";
                    llenar_posicionvolcan();
                    break;
                case 12:
                    txt_nombre.Text = "Abecedario";
                    llenar_posicionabecedario();
                    break;

            }
        }



        //imagenes falsas
        void llenarRamdonImagenFalsas()
        {
            cRamdon obj = new cRamdon();
            //Escoje la imagen 
            res_pic = obj.choose_picture(num_ima);


            switch (res_pic)
            {
                case 1:
                   
                    llenar_posicionbebe();
                    break;
                case 2:
                 
                    llenar_posicioncarro();
                    break;
                case 3:
                  
                    llenar_posicioncolibri();
                    break;
                case 4:
                    
                    llenar_posicionfuego();
                    break;
                case 5:
                   
                    llenar_posicionguitarra();
                    break;
                case 6:
                    
                    llenar_posicionleche();
                    break;
                case 7:
                   
                    llenar_posicionluna();
                    break;
                case 8:
                   
                    llenar_posicionnumero();
                    break;
                case 9:
                 
                    llenar_posicionoso();
                    break;
                case 10:
                  
                    llenar_posicionsol();
                    break;
                case 11:
           
                    llenar_posicionvolcan();
                    break;
                case 12:
                    
                    llenar_posicionabecedario();
                    break;

                }

           
        }//funcion

        

        //eliminate
        void llenar_posicionbebe()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);
            
            switch (res_pos)
            {
                case 1:
                BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pbebe1.png", UriKind.Relative));
                p1.Source = imgSource1;
                break;
                case 2:
                BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pbebe1.png", UriKind.Relative));
                p2.Source = imgSource2;
                break;
                case 3:
                BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pbebe1.png", UriKind.Relative));
                p3.Source = imgSource3;
                break;
                case 4:
                BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pbebe1.png", UriKind.Relative));
                p4.Source = imgSource4;
                break;
            }
         
        }

        void llenar_posicioncarro()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pcarro2.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pcarro2.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pcarro2.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pcarro2.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }


        void llenar_posicioncolibri()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pcolibire3.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pcolibire3.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pcolibire3.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pcolibire3.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }


        void llenar_posicionfuego()
        {
            cRamdon obj = new cRamdon();
          res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pfuego4.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pfuego4.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pfuego4.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pfuego4.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }



        void llenar_posicionguitarra()
        {
            cRamdon obj = new cRamdon();
             res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pguitarra5.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pguitarra5.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pguitarra5.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pguitarra5.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }



        void llenar_posicionleche()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pleche6.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pleche6.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pleche6.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pleche6.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }



        void llenar_posicionluna()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pluna7.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pluna7.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pluna7.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pluna7.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }

        void llenar_posicionnumero()
        {
            cRamdon obj = new cRamdon();
             res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pnumero8.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pnumero8.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pnumero8.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pnumero8.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }


        void llenar_posicionoso()
        {
            cRamdon obj = new cRamdon();
             res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/poso9.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/poso9.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/poso9.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/poso9.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }

        void llenar_posicionsol()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/psol10.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/psol10.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/psol10.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/psol10.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }


        void llenar_posicionvolcan()
        {
            cRamdon obj = new cRamdon();
            res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pvolcan11.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pvolcan11.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pvolcan11.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pvolcan11.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }

        void llenar_posicionabecedario()
        {
            cRamdon obj = new cRamdon();
           res_pos = obj.choose_picture(5);

            switch (res_pos)
            {
                case 1:
                    BitmapImage imgSource1 = new BitmapImage(new Uri("/IMGS/pabecedario12.png", UriKind.Relative));
                    p1.Source = imgSource1;
                    break;
                case 2:
                    BitmapImage imgSource2 = new BitmapImage(new Uri("/IMGS/pabecedario12.png", UriKind.Relative));
                    p2.Source = imgSource2;
                    break;
                case 3:
                    BitmapImage imgSource3 = new BitmapImage(new Uri("/IMGS/pabecedario12.png", UriKind.Relative));
                    p3.Source = imgSource3;
                    break;
                case 4:
                    BitmapImage imgSource4 = new BitmapImage(new Uri("/IMGS/pabecedario12.png", UriKind.Relative));
                    p4.Source = imgSource4;
                    break;
            }

        }


        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            Btn_Ini.Begin();
            Btn_Ini.Completed += Btn_Ini_Completed;
        }

        void Btn_Ini_Completed(object sender, EventArgs e)
        {
            Btn_Ini.Begin();
        }

       

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            Animacion.Begin();
            Animacion.Completed += Animacion_Completed;
            
        }

        void Animacion_Completed(object sender, EventArgs e)
        {
          Animacion.Begin();
        }

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string p = txt_nombre.Text;
            if (p == "Bebe" || p == "Carro" || p == "Colibri")
            {
                txt_nombre.Text = "Correcto";
            }
            else
            {
                txt_nombre.Text = "Incorrecto";
            }
            Animacion.Pause();
        }
        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string p = txt_nombre.Text;
            if (p == "Leche" || p == "Fuego" || p == "Guitarra")
            {
                txt_nombre.Text = "Correcto";
            }
            else
            {
                txt_nombre.Text = "Incorrecto";
            }

            Animacion.Pause();
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string p = txt_nombre.Text;
            if (p == "Luna" || p == "Oso" || p == "Numeros")
            {
                txt_nombre.Text = "Correcto";
            }
            else
            {
                txt_nombre.Text = "Incorrecto";
            }
            Animacion.Pause();
        }

        private void p4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string p = txt_nombre.Text;
            if (p == "Abecedario" || p == "Sol" || p == "Volcan")
            {
                txt_nombre.Text = "Correcto";
            }
            else
            {
                txt_nombre.Text = "Incorrecto";
            }
            Animacion.Pause();
        }
    }
}