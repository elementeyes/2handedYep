using CharacterBuilder.BuilderTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.User
{
    public abstract class UserBase
    {
        public abstract void Construct(AbstractCharacterBuilder charBuilder);
    }
}
