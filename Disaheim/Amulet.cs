using Disaheim;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{


    public class Amulet

    {
        public string ItemId;
        public string Design;
        public Level Quality;

        public Amulet(string itemId) : this("",Level.medium,"")
        {
            ItemId = itemId;
            
        }
        public Amulet (string itemId, Level quality) : this("",quality,"")
        {
            ItemId = itemId;
            Quality = quality;
        }

        public Amulet (string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    } 
}