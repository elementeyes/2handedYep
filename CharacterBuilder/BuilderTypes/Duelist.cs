using CharacterBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.BuilderTypes
{
    public class Duelist : AbstractCharacterBuilder
    {
        public Duelist()
        {
            this.Character = new Character("Duelist");
        }
        public override void BuildWeapon()
        {
            this.Character["weapon"] = "Siege axe";
            this.Character["weapon"] = "Surrender shield";
        }

        public override void BuildArmour()
        {
            this.Character["armour"] = "6l astral plate";
        }

        public override void BuildAbility()
        {
            this.Character["ability"] = "Lacerate YEP";
        }
    }
}
