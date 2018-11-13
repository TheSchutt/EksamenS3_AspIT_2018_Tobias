using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassGrainSort
    {
        public ClassGrainSort()
        {
            
        }
        [Key]
        public int GrainSortId { get; set; }

        private string _grainSort;

        public string GrainSort
        {
            get { return _grainSort; }
            set { _grainSort = value; }
        }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }


       



        



    }
}
