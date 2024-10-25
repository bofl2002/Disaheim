using Disaheim;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
   

    public class Amulet : Merchandise
    {
        public string ItemId;
        public string Design;
        public Level Quality;

        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;

        public Amulet(string itemId) : this("",Level.medium,"") 
        {
            ItemId = itemId;
            
        }
        public Amulet (string itemId, Level quality) : this("",quality,"")
        {
            ItemId = itemId;
            Quality = quality;
        }

        public Amulet (string itemId, Level quality, string design) : base(itemId)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:
                    return 0;
            }
        }
    } 
}