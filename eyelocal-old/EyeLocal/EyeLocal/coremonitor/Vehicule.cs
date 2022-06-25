using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Vehicule
    {
        //Attributes
        string regisNumber;
        string type;
        string brand;
        string assignation;
        long speed;
        int engineState;
        float acceleration;
        int door;
        Tracker tracker;



        //Constructor and methods;

        public Vehicule() { }

        //Getter

        public string getRegNumber() { return this.regisNumber; }
        public string getType() { return this.type; }
        public string getBrand() { return this.brand; }
        public string getAssignation() { return this.assignation; }
        public long getSpeed() { return this.speed; }
        public int getEngineState() { return this.engineState; }
        public float getAcceleration() { return this.acceleration; }
        public int getDoorState() { return this.door; }

        public Tracker getTracker() { return this.tracker; }


        //Setter
        public void setRegNum(string reg) { this.regisNumber = reg; }
        public void setType(string tp) { this.type = tp; }
        public void setBrand(string br) { this.brand = br; }
        public void setAssignation(string assn) { this.assignation = assn; }
        public void setSpeed(long sp) { this.speed = sp; }
        public void setEnginestate(int est) { this.engineState = est; }
        public void setAcceleration(float acc) { this.acceleration = acc; }
        public void setDoorState(int dr) { this.door = dr; }

        
        //Methodes
        public void getSpeed() { }




    }




}
