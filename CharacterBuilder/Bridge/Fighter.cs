using CharacterBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Bridge
{
    public class Fighter : ITypeSystem
    {
        public void ProcessType(string charType)
        {
            Console.WriteLine("Character is {0} Fighter ", charType);
        }
    }
}
