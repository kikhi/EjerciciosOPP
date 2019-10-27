﻿using System;
using System.Collections.Generic;
namespace Musico
{

    
    abstract class Musico 
    {

        protected string nombre; 
        public Musico(string nombre)
        {
        this.nombre=nombre;
        }

        public abstract void Saludo();
        public abstract void Afina();

    }

    class Bajista:Musico // se hereda de la calse musico
    {
       private string bajo;
       public Bajista(string no,string b):base(no)   //se utiliza this en caso de ambiguedad si hubieran dos variables con el mismo nombre
       {
       bajo=b;
       } 
       public override void  Saludo()
       {
           Console.WriteLine("{0} esta saludando al publico",nombre);
       }
       public override void  Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }

    }

    class Guitarrista:Musico // clase guitarrista se hereda de musico
    {   
        private string Guitarra;
        public Guitarrista(string gui,string g):base(gui)
        {
            Guitarra=g;
        }
        public override void  Saludo()
       {
           Console.WriteLine("{0} esta saludando al publico",nombre);
       }

        public override void Afina()
        {
            Console.WriteLine("{0}, esta afinando su Guitarra {1}",nombre,Guitarra);
        }
    }

    class Baterista:Musico // clase baterista heredada de musico
    {
        private string Bateria;

     public Baterista(string bat,string b):base(bat)
     {
         Bateria=b;

     }

    public override void  Saludo()
       {
           Console.WriteLine("{0} esta saludando al publico",nombre);
       }
     public override void Afina()
     {
         Console.WriteLine("{0} esta tocando los platillos de su bateria {1}",nombre,Bateria);

     }
        
    }
    class Program
    { 

        static void Main()
        {
            //Musico tom=new Musico("Tom");   // se declaran los objetos que vamos a utilizar con sus respectivos valores
            Bajista flea=new Bajista("Flea","MusicMan");
            Guitarrista jason = new Guitarrista("Jason","Storm");
            Baterista Lois = new Baterista("Lois","Yamaha");
           // tom.Saludo();
           // flea.Saludo();

          //  tom.Afina();
          //  flea.Afina();

            List <Musico> grupo = new List <Musico>();
            //grupo.Add(tom);
            grupo.Add(flea);
            grupo.Add(jason);
            grupo.Add(Lois);
            foreach(Musico m in grupo)
                {
                    m.Saludo();
                    m.Afina();
                }
        }
    }
}