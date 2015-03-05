using Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Characteristics
{
    class Scaredy : AICharacteristic
    {

        public Scaredy(AIAgent agent)
            : base(agent)
        {

        }

        public Scaredy()
            : base()
        {

        }

        override public void React(GameEvent theEvent)
        {
            if (theEvent.Type == "Vision")
            {
                //on va ajouter l'action 'RUN' à l'agent
                Agent.RegisterAction(new Run());
            }
        }
    }
}
