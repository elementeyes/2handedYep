using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.State
{
    public class MovingState : IState
    {
        public override string Move(Context context)
        {
            return "You move around randomly";
        }
        public override string Attack(Context context)
        {
            return "You need to stop moving first";
        }
        public override string Stop(Context context)
        {
            context.State = new RestingState();
            return "You stand still in a dark room";
        }
        public override string Run(Context context)
        {
            return "You run around in cirles";
        }
        public override string Panic(Context context)
        {
            context.State = new PanicingState();
            return "You start Panicking and begin seeing things";
        }
        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "You stand still and relax";
        }
    }
}
