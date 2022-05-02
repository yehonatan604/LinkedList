using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillHandler bh200 = new BillHandler200();
            BillHandler bh100 = new BillHandler100();
            BillHandler bh50 = new BillHandler50();
            BillHandler bh20 = new BillHandler20();

            bh200.SetNext(bh100);
            bh100.SetNext(bh50);
            bh50.SetNext(bh20);
            bh20.SetNext(null);

            Console.WriteLine("Withdrawing 770:\n");
            bh200.HandleRequest(770);
            Console.WriteLine("\nWithdrawing 210:\n");
            bh200.HandleRequest(210);
        }
    }
}
