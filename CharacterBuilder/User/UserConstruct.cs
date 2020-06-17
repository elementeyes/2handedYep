using CharacterBuilder.BuilderTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.User
{
    public class UserConstruct : UserBase
    {
        public override void Construct(AbstractCharacterBuilder charBuilder)
        {
            charBuilder.BuildWeapon();
            charBuilder.BuildArmour();
            charBuilder.BuildAbility();
        }
    }
}
