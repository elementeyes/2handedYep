using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Model
{
    public class Character
    {
        public readonly string characterType;
        public readonly Dictionary<string, string> feautures = new Dictionary<string, string>();

        public Character(string characterType)
        {
            this.characterType = characterType;
        }
        public string this[string key]
        {
            get { return this.feautures[key]; }
            set { this.feautures[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n -------------");
            Console.WriteLine("Character Type: {0}", this.characterType);
            Console.WriteLine(" Weapon: {0}", this.feautures["weapon"]);
            //if (this.feautures.ContainsKey("weapon"))
            //{
            //    Console.WriteLine(" Brakes: {0}", this.feautures["weapon"]);
            //}
            Console.WriteLine(" Armour: {0}", this.feautures["armour"]);
            Console.WriteLine(" Special ability: {0}", this.feautures["ability"]);

        }
    }
}
