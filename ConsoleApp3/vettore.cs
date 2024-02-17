﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class vettore
    {
        public double x { get; set; }
        public double y { get; set; }

        public vettore(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static double operator *(vettore v1, vettore v2)
        {
            return (v1.x * v2.x) + (v1.y * v2.y);
        }


        /*
        public static double sommastatic(vettore v1, vettore v2)
        {
            double somma = (v1.x * v2.x) + (v1.y * v2.y);
            return somma;
        }

        public double somma(vettore v1)
        {
            return v1.x * x + v1.y * y;
        }
        */
        public static vettore operator +(vettore v1, vettore v2)
        {
            vettore res = new vettore(v1.x + v2.x, v1.y + v2.y);
            return res;
        }


        public static vettore operator -(vettore v1, vettore v2)
        {
            return new vettore(v1.x - v2.x, v1.y - v2.y);
        }

        public static vettore operator *(vettore v1, double s)
        {
            vettore res = new vettore(v1.x * s, v1.y * s);
            return res;
        }

        public static vettore operator *(double s, vettore v1)
        {
            vettore res = new vettore(v1.x * s, v1.y * s);
            return res;
        }

        public static vettore operator /(vettore v1, double s)
        {
            vettore res = new vettore(v1.x / s, v1.y / s);
            return res;
        }

        public static vettore operator -(vettore v)
        {
            return new vettore(-v.x, -v.y);
        }

        public static vettore operator +(vettore v)
        {
            return v;
        }

        public override string ToString()
        {
            return String.Format("vettore : [{0} , {1}]", x, y);
        }
    }
}
