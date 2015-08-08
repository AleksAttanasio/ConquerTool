using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquerToolMethod
{
    public class Attack
    {
        private int xDestination;
        private int yDestination;
        private DateTime startHour;
        private string villageName;
        public enum Type
        {
            FAKE,
            CONQUISTA
        }

        private Type attackType;


        /* Constructors */
        public Attack(int xD, int yD, DateTime startA)
        {
            this.DestinationY = yD;
            this.DestionationX = xD;
            this.StartHour = startA;
        }
        public Attack(int xD, int yD, DateTime startA, string villageN)
        {
            this.DestinationY = yD;
            this.DestionationX = xD;
            this.StartHour = startA;
            this.VillageName = villageN;
        }

        public Attack(int xD, int yD, DateTime startA, Type type)
        {
            this.DestinationY = yD;
            this.DestionationX = xD;
            this.StartHour = startA;
            this.AttackType = type;
        }
        /* Properties */
        public Type AttackType
        {
            get { return attackType; }
            set { attackType = value; }
        }
        public string VillageName
        {
            get { return villageName; }
            set { villageName = value; }
        }
        
        public DateTime StartHour
        {
            get { return startHour; }
            set { startHour = value; }
        }
        
        public int DestinationY
        {
            get { return yDestination; }
            set { yDestination = value; }
        }
        

        public int DestionationX
        {
            get { return xDestination; }
            set { xDestination = value; }
        }
        
    }
}
