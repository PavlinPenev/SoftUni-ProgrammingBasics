using System;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double billOthers = 0;
            double waterBill = 20;
            double internetBill = 15;
            double electricityBill = 0;
            for (int i = 0; i < month; i++)
            {
                double electricityBillMonth = double.Parse(Console.ReadLine());

                billOthers += (waterBill + internetBill + electricityBillMonth) * 1.20;
                electricityBill += electricityBillMonth;
            }
            waterBill *= month;
            internetBill *= month;
            double averageBillsMonthly = (waterBill + internetBill + electricityBill + billOthers) / month;
            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {billOthers:f2} lv");
            Console.WriteLine($"Average: {averageBillsMonthly:f2} lv");
        }
    }
}
