using System;

namespace FarmSystem.Test1
{
    public class Hen : IAnimal
    {
        private string _id;
        private int _noOfLegs = 4;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        
        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public void EnterFarm()
        {
            Console.WriteLine("{0} has entered the farm", this.ToString());

            //do all other activities required specific to this animal type
        }

        public void ReleasefromFarm()
        {
            Console.WriteLine("{0} has left the farm", this.ToString());

            //do all other activities required specific to this animal type
        }
    }
}