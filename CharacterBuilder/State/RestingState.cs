using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.State
{
    public class RestingState : IState
    {
        public override string Move(Context context)
        {
            context.State = new MovingState();
            return "You start moving";
        }
        public override string Attack(Context context)
        {
            context.State = new AttackingState();
            return "You start attacking the darkness";
        }
        public override string Stop(Context context)
        {
            return "You are already stopped!";
        }
        public override string Run(Context context)
        {
            return "You cannot run unless you are moving";
        }
        public override string Panic(Context context)
        {
            context.State = new PanicingState();
            return "You start Panicking and begin seeing things";
        }
        public override string CalmDown(Context context)
        {
            return "You are already relaxed";
        }
    }
}
