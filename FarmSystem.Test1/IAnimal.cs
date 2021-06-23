using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// Animal and its Activities
    /// </summary>
    public interface IAnimal
    {
        void EnterFarm();
        void Talk();
        void Run();
        void ReleasefromFarm();
    }
}
