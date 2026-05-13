using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public struct PlayerStruct
    {
         public PlayerClass PClass {get;}
        public string Name {get;}
        public PlayerStruct(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }
    }
}