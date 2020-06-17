using CharacterBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.BuilderTypes
{
    public class Guardian : AbstractCharacterBuilder
    {
        public Guardian()
        {
            this.Character = new Character("Guardian");
        }
        public override void BuildWeapon()
        {
            this.Character["weapon"] = "Shield";
        }

        public override void BuildArmour()
        {
            this.Character["armour"] = "Astral plate";
        }

        public override void BuildAbility()
        {
            this.Character["ability"] = "Earthquake YEP";
        }
    }
}
