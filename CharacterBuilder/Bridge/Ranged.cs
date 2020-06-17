using CharacterBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Bridge
{
    public class Ranged : Interfaces.Type
    {
        public override void MakeType()
        {
            _ITypeSystem.ProcessType("Melee");
        }
    }
}
