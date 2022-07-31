using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            /*instance object*/
            clothesList clothesList = new clothesList();

            Clothes s1 = new Clothes();
            s1.Id = "S1";
            s1.Name = "thun";
            s1.Company = "adias";
            s1.Money = "20.000d";
            s1.Size = "M";
     
            clothesList.addClothes(s1);
          

            Clothes s2 = new Clothes("S2", "gio", "adias", "50.000d" , "M");
           clothesList.addClothes(s2);

            Clothes s3 = new Clothes();
            s3.Id = "S3";
            s3.Name = "3 lo";
            s3.Company = "bumbo";
            s3.Money = "100.000d";
            s3.Size = "S";
            clothesList.addClothes(s3);


            Clothes s4 = new Clothes();
            s4.Id = "S4";
            s4.Name = "thun";
            s4.Company = "T.shirt";
            s4.Money = "50.000d";
            s4.Size = "M";
          clothesList.addClothes(s4);

           
            /* call methods */
            s1.showClothDetails();
            Console.WriteLine("--------------");
            s2.showClothDetails();
            Console.WriteLine("--------------");
            s3.showClothDetails();
            Console.WriteLine("--------------");
            s4.showClothDetails();


            Console.WriteLine("Enter Name Watch to search: ");
            String enterName = Console.ReadLine();//nhập giá trị tìm kiếm

            clothesList.searchClothesByName(enterName);//tìm kiem gia tri
        

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
