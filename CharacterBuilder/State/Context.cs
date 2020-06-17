using CharacterBuilder.Bridge;
using CharacterBuilder.BuilderTypes;
using CharacterBuilder.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.State
{
    public class Context
    {
        public IState State { get; set; }

        public void Request(char c)
        {
            string result;
            switch (char.ToLower(c))
            {
                case 'm': result = State.Move(this); break;
                case 'a': result = State.Attack(this); break;
                case 's': result = State.Stop(this); break;
                case 'r': result = State.Run(this); break;
                case 'p': result = State.Panic(this); break;
                case 'c': result = State.CalmDown(this); break;
                case 'e': result = "Thank you for playing"; break;
                default: result = "Error, try again"; break;
            }
            Console.WriteLine(result);
        }
        public void SelectRequest(char c) 
        {
            AbstractCharacterBuilder builder;
            var director = new UserConstruct();
            Fighter fighter = new Fighter();
            Caster caster = new Caster();
            switch (char.ToLower(c))
            {
                case 'd':  builder = new Duelist();
                    director.Construct(builder);
                    builder.Character.Show();
                    fighter.ProcessType("Melee");
                    break;
                case 'g':  builder = new Guardian();
                    director.Construct(builder);
                    builder.Character.Show();
                    caster.ProcessType("Melee");
                    break;
                case 'm':  builder = new Marauder(); 
                    director.Construct(builder);
                    builder.Character.Show();
                    fighter.ProcessType("Melee");
                    break;
                case 'w':  builder = new Witch(); 
                    director.Construct(builder);
                    builder.Character.Show();
                    caster.ProcessType("Ranged");
                    break;
                default: Console.WriteLine("Error, try again"); break;
            }
        }
    }
}
