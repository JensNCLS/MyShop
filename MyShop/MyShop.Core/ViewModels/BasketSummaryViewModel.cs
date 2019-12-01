using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class BasketSummaryViewModel
    {
        public int Basketcount { get; set; }
        public decimal Basketvalue { get; set; }

        public BasketSummaryViewModel()
        {

        }
        public BasketSummaryViewModel(int basketcount, decimal basketvalue)
        {
            this.Basketcount = basketcount;
            this.Basketvalue = basketvalue;
        }
    }
}
