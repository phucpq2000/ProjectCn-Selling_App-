using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Clothes
    {
        /* properties */

        public string Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
      
        public string Company
        {
            get; set;
        }
        public string Money
        {
            get; set;
        }
        public string Size
        {
            get; set;
        }


        /* constructors */
        // overloading
        public Clothes()
        {
            Id = "S000000";

        }
        public Clothes(string Id, string Name, string Company, string Money, string Size)
        {
            this.Id = Id;
            this.Name = Name;
            this.Company = Company;
            this.Money = Money;
            this.Size = Size;

        }

        /* methods*/
        public void showClothDetails()
        {
            Console.WriteLine("ClothesId {0} ", Id);
            Console.WriteLine("ClothesName {0} ", Name);
            Console.WriteLine("Company{0} ", Company);
            Console.WriteLine("Money {0} ",Money);
            Console.WriteLine("Size {0} ", Size);


        }
    }
}
