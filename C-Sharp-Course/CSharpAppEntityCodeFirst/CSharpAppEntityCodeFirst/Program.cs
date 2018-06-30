using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAppEntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ReceiptContext())
            {
                Console.Write("Enter item purchased: ");
                string itemPurchased = Console.ReadLine();
                Console.Write("Enter item amount: ");
                decimal itemAmount = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter date when item was purchased: ");
                string datePurchased = Console.ReadLine();

                var receipt = new Receipt { Item = itemPurchased, Amount = itemAmount, Date = datePurchased };
                
                db.Receipts.Add(receipt);                
                db.SaveChanges();
            }
        }
    }
}
