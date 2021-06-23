using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public delegate void AddtoQueue(object obj);
    public delegate void ReleasefromQueue(object obj);
    public delegate void EmptyQueue();
    
    /// <summary>
    /// Custom Queue Class
    /// </summary>
    public class AnimalQueue<T>: Queue
    {
        public event AddtoQueue onAddtoFarm;
        public event ReleasefromQueue onReleasefromFarm;
        public event EmptyQueue onFarmEmpty;
      
        public override void Enqueue(object obj)
        {
            base.Enqueue(obj);
            if(onAddtoFarm != null)
                onAddtoFarm(obj);
        }

        public override object Dequeue()
        {
            var obj = base.Dequeue();

            if(onReleasefromFarm != null)
                onReleasefromFarm(obj);

            if (base.Count == 0)
            {
                if (onFarmEmpty != null)
                    onFarmEmpty();
            }
            return obj;
        }
    }
}
