﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Vare
    {
        public Vare()
        {

        }
        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.Navn = navn;

        }
        private string navn;
        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return navn; }
            set {
                Console.WriteLine("Nu tildeles navn");
                navn = value; }
        }

        private double pris;
        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set {
                Console.WriteLine("Nu tildeles pris");
                pris = value; }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Hest";
            v.Pris = 125;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("Hestevogn", 75);
            Console.WriteLine(v2.PrisMedMoms());
        }
    }
}
