using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amad.BL
{
    internal class SaveData
    {
        public string nameOfCart;
        public string nameEntity1;
        public string priceEntity1;
        public string nameEntity2;
        public string priceEntity2;
        public string nameEntity3;
        public string priceEntity3;
        public string nameEntity4;
        public string priceEntity4;
        public SaveData(string nameOfCart,string nameEntity1,string priceEntity1,string nameEntity2,string priceEntity2,string nameEntity3,string priceEntity3,string nameEntity4,string priceEntity4)
        {
            this.nameOfCart = nameOfCart;
            this.nameEntity1=nameEntity1;
            this.priceEntity1=priceEntity1;
            this.nameEntity2=nameEntity2;
            this.priceEntity2 = priceEntity2;  
            this.nameEntity3=nameEntity3;
            this.priceEntity3 = priceEntity3;  
            this.nameEntity4=nameEntity4;
            this.priceEntity4=priceEntity4;

        }
    }
}
