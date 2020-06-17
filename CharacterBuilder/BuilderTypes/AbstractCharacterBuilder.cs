using System;
using System.Collections.Generic;
using System.Text;
using CharacterBuilder.Model;
namespace CharacterBuilder.BuilderTypes
{
    public abstract class AbstractCharacterBuilder
    {
        public Character Character { get; set; }

        public abstract void BuildWeapon();
        public abstract void BuildArmour();
        public abstract void BuildAbility();
    }
}
