﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
          //DortIslem dortIslem= new DortIslem(2,3);  
          //Console.WriteLine(dortIslem.Topla2());
          //Console.WriteLine(dortIslem.Topla(3,4));

          var tip = typeof(DortIslem);
          //DortIslem dortIslem=(DortIslem)Activator.CreateInstance(tip,6,7);
          //Console.WriteLine(dortIslem.Topla(2,3));
          //Console.WriteLine(dortIslem.Topla2());
          var instance=Activator.CreateInstance(tip, 6, 5);
          //instance.GetType().GetMethod("Topla2").Invoke(instance,null);
          MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
          Console.WriteLine(methodInfo.Invoke(instance, null));
          Console.WriteLine("_______________________________");
          var methodlar = tip.GetMethods();
          foreach (var info in methodlar)
          {
              Console.WriteLine($"methodlar {info.Name}");
              foreach (var parameterInfo in info.GetParameters())
              {
                  Console.WriteLine($"parametreleri: {parameterInfo.Name}");
              }

              foreach (var attributes in info.GetCustomAttributes())
              {
                  Console.WriteLine($"Attibute Name: {attributes.GetType().Name}");     
              }
          }

        



          Console.ReadKey();

        }
    }



    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }


        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 +sayi2;
        }


        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MethodNameAttribute : Attribute
    {
        private string _name;
        public MethodNameAttribute(string name)
        {
            _name = name;
        }
    }
}
