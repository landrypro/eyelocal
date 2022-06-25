using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Tracking
    {
        //Attributes

        int id;
        Tracker tracker;
        Vehicule car;
        Position position;

        //Constructor and Method
        public Tracking() { }

        public Tracking(int idt, Tracker trck, Vehicule cr, Position post)
        {
            this.id = idt;
            this.tracker = trck;
            this.car = cr;
            this.position = post;
        }

        public Tracking(Position post)
        {
          this.position = post;
        }
        // public Tracking ()


        //Getter

        public int getID() { return this.id; }
        public Vehicule getCar() { return this.car; }
        public Tracker getTracker() { return this.tracker; }
        public Position getPosition() { return this.position; }

        //Get info all info track
        public Tracking getTrackingInfo() { return this; }
        //..

        //Setter
        public void setID(int idt) { this.id = idt; }
        public void setCar(Vehicule cr) { this.car = cr; }
        public void setTracker(Tracker tr) { this.tracker = tr; }
        public void setPosition(int po) { this.id =po; }
        





    }
}
