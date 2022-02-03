using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipLoader
{
     class Ship
    {
        // const values
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_COUNT = 10;
        

        // class properties
        public int MaxCapacity { get; set; }
        public int CycleCount { get; set; }
        public int TruckCount { get; set; }
        public int CarCount { get; set; }
        public int TrainCount { get; set; }

        Random random = new Random();

        // constructor
        public Ship()
        {
            // properties initialization
            CycleCount=0;  
            TrainCount=0;
            CarCount=0;
            TruckCount=0;   

            //random ship size
            MaxCapacity = random.Next(MAX_COUNT)* (CYCLE_WEIGHT+TRAIN_WEIGHT+TRUCK_WEIGHT+CAR_WEIGHT)  ;

        }

        // methods
        public int getCurrentShipLoad ()
        {
            return CycleCount*CYCLE_WEIGHT + TrainCount*TRAIN_WEIGHT + TruckCount*TRUCK_WEIGHT + CarCount*CAR_WEIGHT ;
        }

        public int howLoaded()
        {
            return MaxCapacity - getCurrentShipLoad();
        }

        public override string ToString()
        {
            return String.Format("Max Capacity = {0} & Current Load = {1}", MaxCapacity , getCurrentShipLoad());
        }
    }
}
