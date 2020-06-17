using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.State
{
    public class AttackingState : IState
    {
        public override string Move(Context context)
        {
            return "You need to stop attacking first";
        }
        public override string Attack(Context context)
        {
            return "You attack the darkness for " +
           (new Random().Next(20) + 1) + " damage";
        }
        public override string Stop(Context context)
        {
            context.State = new RestingState();
            return "You are calm down and come to rest";
        }
        public override string Run(Context context)
        {
            context.State = new MovingState();
            return "You Run away from the fray";
        }
        public override string Panic(Context context)
        {
            context.State = new PanicingState();
            return "You start Panicking and begin seeing things";
        }
        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "You fall down and sleep";
        }
    }
}
