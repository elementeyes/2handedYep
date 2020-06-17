using CharacterBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.BuilderTypes
{
    public class Witch : AbstractCharacterBuilder
    {
        public Witch()
        {
            this.Character = new Character("Witch");
        }
        public override void BuildWeapon()
        {
            this.Character["weapon"] = "Wand";
            this.Character["weapon"] = "Shield";
        }

        public override void BuildArmour()
        {
            this.Character["armour"] = "Shavs";
        }

        public override void BuildAbility()
        {
            this.Character["ability"] = "Winter Orb YEP";
        }
    }
}
