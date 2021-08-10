using System;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int patientsRejected = 0;
            int patients = 0;

            int doctors = 7;
            for (int i = 1; i <= days; i++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());
                int patientsRejectedDaily = 0;
                if (i % 3 == 0)
                {
                    doctors += (patients < patientsRejected) ? 1 : 0;
                }
                if (patientsPerDay > doctors)
                {
                    patientsRejected += (patientsPerDay - doctors);
                    patientsRejectedDaily += (patientsPerDay - doctors);
                    patientsPerDay -= patientsRejectedDaily;
                }

                patients += patientsPerDay;
            }
            Console.WriteLine($"Treated patients: {patients}.");
            Console.WriteLine($"Untreated patients: {patientsRejected}.");
        }
    }
}
