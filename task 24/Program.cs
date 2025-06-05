using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceRepository re = new InvoiceRepository();
            List<Invoice> inv = re.Invoices;

            Console.WriteLine("1 - N 12:");
            foreach (Invoice i in inv)
            {
                if (i.Id == 12)
                {
                    Console.WriteLine(i.ClientName);
                }
            }

            Console.WriteLine("\n2 - Unpaid:");
            foreach (Invoice i in inv)
            {
                if (i.IsPaid == false)
                {
                    Console.WriteLine(i.ClientName);
                }
            }

            Console.WriteLine("\n3 - CLient 'White':");
            bool found = false;
            foreach (Invoice i in inv)
            {
                if (i.ClientName.Contains("White"))
                {
                    found = true;
                }
            }
            if (found) Console.WriteLine("yes");
            else Console.WriteLine("no");

            Console.WriteLine("\n4 - amount > 1000:");
            int c = 0;
            foreach (Invoice i in inv)
            {
                if (i.Amount > 1000)
                {
                    c = c + 1;
                }
            }
            Console.WriteLine(c);

            Console.WriteLine("\n5 - sorting:");
            for (int a = 0; a < inv.Count - 1; a++)
            {
                for (int b = a + 1; b < inv.Count; b++)
                {
                    if (inv[a].IssueDate > inv[b].IssueDate)
                    {
                        Invoice temp = inv[a];
                        inv[a] = inv[b];
                        inv[b] = temp;
                    }
                }
            }
            foreach (Invoice i in inv)
            {
                Console.WriteLine(i.Id + "." + i.ClientName + " " + i.Amount + ": " + "(" + i.IssueDate.ToShortDateString() + ")");
            }

            int itor = -1;
            Invoice ri = null;
            for (int i = 0; i < inv.Count; i++)
            {
                if (inv[i].Id == 5)
                {
                    itor = i;
                    ri = inv[i];
                }
            }
            if (itor != -1)
            {
                inv.RemoveAt(itor);
                Console.WriteLine("\n6 - delete number:\n" + ri.Id + "." + ri.ClientName + " " + ri.Amount);
            }

            Invoice noe = new Invoice(31, "new c", DateTime.Now, 890.90m, false);
            inv.Add(noe);
            Console.WriteLine("\n7 - New:\n" + noe.Id + "." + noe.ClientName + ", сума: " + noe.Amount);

            Console.WriteLine("\n8 - All:");
            foreach (Invoice i in inv)
            {
                Console.WriteLine(i.Id + "." + i.ClientName + " " + i.Amount);
            }

            Console.WriteLine("\n9 - Dictionary:");
            Dictionary<int, Invoice> dict = new Dictionary<int, Invoice>();
            foreach (Invoice i in inv)
            {
                dict[i.Id] = i;
            }

            List<int> ids = new List<int>(dict.Keys);
            for (int i = ids.Count - 1; i >= 0; i--)
            {
                int id = ids[i];
                Invoice invv = dict[id];
                Console.WriteLine(invv.Id + "." + invv.ClientName);
            }
        }
    }
}

