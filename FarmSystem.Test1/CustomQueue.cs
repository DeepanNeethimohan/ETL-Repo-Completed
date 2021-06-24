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
    /// Custom Generic Queue Class
    /// </summary>
    public class CustomQueue<T>: Queue
    {
        public event AddtoQueue onEnqueue;
        public event ReleasefromQueue onDequeue;
        public event EmptyQueue onEmpty;
      
        public override void Enqueue(object obj)
        {
            base.Enqueue(obj);
            if(onEnqueue != null)
                onEnqueue(obj);
        }

        public override object Dequeue()
        {
            var obj = base.Dequeue();

            if(onDequeue != null)
                onDequeue(obj);

            if (base.Count == 0)
            {
                if (onEmpty != null)
                    onEmpty();
            }
            return obj;
        }
    }
}
