using System;


namespace whatdelegate //Delegate Metodlari referans edir.//metdolari daha yaxsi yonetmek ucun istf olunur
{
   public class Program
   {
        // delegate double Dordbucaqli(double x, double y);
        delegate void Dordbucaqli(double x, double y);
        static void Main()
        {
            Dordbucaqli test = cevre;
            // Dordbucaqli test = new Dordbucaqli(sahe);
          //  Dordbucaqli test = new Dordbucaqli(cevre);
            test += sahe;
            // Console.WriteLine(test(2, 4));
            test(2, 4);
            Console.WriteLine("test(2,4)");
            test -= cevre;
            test(2, 4);

            Console.ReadLine();
        }
       
       // static double cevre(double a,double b)
       static void cevre(double a,double b)
       {
            //return 2 * (a + b);
            Console.WriteLine(2 * (a + b));

       }
        

       // static double sahe(double a, double b)
       static void sahe(double a,double b)
       {
            // return a * b;
            Console.WriteLine(a*b);
       }







        
        
          
}  }   