using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    // Our POCO


    public class AdventureProps
    {
        public CharacterType Characters { get; set; }
 
    }

    public enum CharacterType
    {
        Warrior,
        Cthulu,
        Elf,
        Archer,
        Citizen
    }


}

