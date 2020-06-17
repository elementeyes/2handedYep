using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Interfaces
{
    public abstract class Type
    {
        public ITypeSystem _ITypeSystem;
        public abstract void MakeType();
    }
}
