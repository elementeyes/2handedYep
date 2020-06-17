using CharacterBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Bridge
{
    public class Caster : ITypeSystem
    {
        public void ProcessType(string charType)
        {
            Console.WriteLine("Character is {0} Caster ", charType);
        }
    }
}
