using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    //Program-3
    //3. Create a class named RBI with calculateInterest() method.Create another
    //classes HDFC, SBI, ICICI which overrides calculateInterest() method.

    internal class RBI
    {
        public virtual void calculateInterest(double P , float R , float N)
        {
            Console.WriteLine("Simple Interest Of RBI = " + (P * R * N) / 100);
        }
    }
    class HDFC : RBI
    {
        public override void calculateInterest(double P1, float R1, float N1)
        {
            Console.WriteLine("Simple Interest Of HDFC = " + (P1 * R1 * N1) / 100);
        }
    }
    class SBI : RBI
    {
        public override void calculateInterest(double P2, float R2, float N2)
        {
            Console.WriteLine("Simple Interest Of SBI = " + (P2 * R2 * N2) / 100);
        }
    }
    class ICICI : RBI
    {
        public override void calculateInterest(double P3, float R3, float N3)
        {
            Console.WriteLine("Simple Interest Of ICICI = " + (P3 * R3 * N3) / 100);
        }
    }
}
