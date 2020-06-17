using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.State
{
    public class PanicingState : IState
    {
        public override string Move(Context context)
        {
            return "You move around randomly in a blind panic";
        }
        public override string Attack(Context context)
        {
            return "You start attacking the darkness, but keep on missing";
        }
        public override string Stop(Context context)
        {
            context.State = new MovingState();
            return "You are start relaxing, but keep on moving";
        }
        public override string Run(Context context)
        {
            return "You run around in your panic";
        }
        public override string Panic(Context context)
        {
            return "You are already in a panic";
        }
        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "You relax and calm down";
        }
    }
}
