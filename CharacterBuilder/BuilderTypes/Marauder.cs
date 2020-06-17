using CharacterBuilder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.BuilderTypes
{
    public class Marauder : AbstractCharacterBuilder
    {
        public Marauder()
        {
            this.Character = new Character("Marauder");
        }
        public override void BuildWeapon()
        {
            this.Character["weapon"] = "2Hand Mace YEP";
        }

        public override void BuildArmour()
        {
            this.Character["armour"] = "Kaoms heart YEP";
        }

        public override void BuildAbility()
        {
            this.Character["ability"] = "Earthquake YEP";
        }        
    }
}
