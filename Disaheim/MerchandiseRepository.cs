using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        Utility utility = new Utility();

        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (merchandises[i].ItemId == itemId)
                {
                    return merchandises[i];
                }
            }
            return null;
        }

        public double GetTotalValue(Merchandise merchandise)
        {
            double total = 0;
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (utility.GetValueOfMerchandise(merchandises[i]) > 0)
                {
                    total = total + utility.GetValueOfMerchandise(merchandises[i]);
                }
            }
            return total;
        }
        

        
    }
}
