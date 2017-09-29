using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarsys
{
    public class Planner
    {
        private List<Destination> destinationRoutes = new List<Destination>();

        public List<Destination> getList()
        {
            return destinationRoutes;
        }

        public void addDestination(Destination next, Destination previous)
        {

            if (destinationRoutes.Contains(next) && !destinationRoutes.Contains(previous))
            {
                next.setDestination(previous);
            }
            if (!next.getName().Equals(" ") && !destinationRoutes.Contains(next))
            {
                destinationRoutes.Add(next);
            }
            if (!destinationRoutes.Contains(previous))
            {
                destinationRoutes.Add(previous);
            }
            
            
        }

       
        public bool IsCircular()
        {
            Destination fast = destinationRoutes[1];
            Destination slow =destinationRoutes[0];
            while (slow != null && fast != null)
            {
                if (slow.Equals(fast))
                {
                    return true;
                }
                if (fast.getDestination() != null && slow.getDestination() != null)
                {
                    fast = fast.getDestination().getDestination();
                    slow = slow.getDestination();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        
    }
}
