using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class clothesList
    {
        private List<Clothes> _clothesList;
        public clothesList()
        {
            _clothesList = new List<Clothes>();
        }

        /* methods*/

        public void addClothes(Clothes clo)
        {
            _clothesList.Add(clo);
        }
        public void getAllClothes()
        {

            foreach (Clothes clothes in _clothesList)
            {
                clothes.showClothDetails();
                Console.WriteLine("============");
            }
        }

        public void searchClothesByName(String enterSearch)
        {

            foreach (Clothes clo in _clothesList)
            {
                if (clo.Name == enterSearch)
                {
                    clo.showClothDetails();
                    //Console.WriteLine("============");
                }
            }
        }
    }
}

