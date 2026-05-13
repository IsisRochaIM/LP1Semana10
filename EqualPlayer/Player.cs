using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass {get;}
        public string Name {get;}
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        public int GetNameHashCode()
        {
            return Name.GetHashCode();
        }

        public int GetClassHashCode()
        {
            return PClass.GetHashCode();
        }

        //Faz override dos métodos GetHashCode() e Equals() de modo a que um jogador seja considerado único
        //no jogo se tiver o mesmo tipo e o mesmo nome.
        //Uma forma rápida de obter um hash code para o tipo Player consiste em realizar a operação XOR (ˆ) no hash code dos seus dois campos.
        public override int GetHashCode()
        {
            return PClass.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Player other)
            {
                return GetHashCode() == obj.GetHashCode();
            }
            else
            {
                return false;
            }
        }
    }
}