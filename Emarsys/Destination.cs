using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emarsys
{
    public class Destination
    {
        private string name;
        private bool visited;
        Destination destination;

        public Destination(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public bool isVisited()
        {
            return visited;
        }

        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        public Destination getDestination()
        {
            return destination;
        }

        public void setDestination(Destination destination)
        {
            this.destination = destination;
        }

        public override bool Equals(object obj)
        {
            if (obj is Destination)
            {
                Destination d = (Destination)obj;
                return d.name.Equals(this.name);

            }
            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
