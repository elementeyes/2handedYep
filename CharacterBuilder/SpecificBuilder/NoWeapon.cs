using CharacterBuilder.BuilderTypes;
using CharacterBuilder.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.SpecificBuilder
{
    public class NoWeapon : UserBase
    {
        public override void Construct(AbstractCharacterBuilder charBuilder)
        {
            charBuilder.BuildArmour();
            charBuilder.BuildAbility();
        }
    }
}
