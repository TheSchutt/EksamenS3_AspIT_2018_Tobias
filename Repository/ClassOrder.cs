using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassOrder
    {
        public ClassOrder()
        {

        }
        [Key]
        public int OrderId { get; set; }

        private int weight;
        private decimal orderPrice;

        public int Weight
        {
            get => weight;
            set
            {
                if (value != weight)
                {
                    weight = value;
                    
                }
            }
        }
        public DateTime OrderDate { get; set; }

        public decimal OrderPrice
        {
            get => orderPrice;
            set
            {
                if (value != orderPrice)
                {
                    orderPrice = value;
                    
                }
            }
        }
        [ForeignKey("GrainSort")] //Foregin key to the classGrainSort
        public int GrainSortId { get; set; }
        public ClassGrainSort GrainSort { get; set; }

        [ForeignKey("User")] //Foregin key to the classUser
        public int UserId { get; set; }
        public ClassUser User { get; set; }

        [ForeignKey("Supplier")] //Foregin key to the classGrainSupplier
        public int SupplierId { get; set; }
        public ClassSupllier Supplier { get; set; }

        [ForeignKey("Valuta")] //Foregin key to the classGrainSort
        public int ValutaId { get; set; }
        public ClassValuta Valuta { get; set; }

        private decimal _salePrice;

        public decimal SalePrice
        {
            get { return _salePrice; }
            set { _salePrice = value; }
        }




    }
}
