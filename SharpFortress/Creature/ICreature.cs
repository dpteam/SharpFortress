using SharpFortress.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFortress.Creature
{
   public interface ICreature
    {
        IRace Race { get; }
    }
}
