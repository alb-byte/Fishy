using Fishy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FishyContext context = new FishyContext();
            FRIEND f = new FRIEND();
            f.ID1 = 1;
            f.ID2 = 2;
            context.FRIENDS.Add(f);
            context.SaveChanges();

        }
    }
}
