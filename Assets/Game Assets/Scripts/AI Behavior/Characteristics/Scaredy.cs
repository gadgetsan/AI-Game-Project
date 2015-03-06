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
            if (theEvent.Type == "Close")
            {
                //on va regarder ou est la source de l'event pour aller dans l'autre direction
                Vector3 delta = Agent.transform.position - theEvent.Source.transform.position;
                Debug.Log("delta: " + delta.ToString());
                if (Level > 75)
                {
                    //l'Agent cours un peu plus loin de l'utilisateur et cris
                    Agent.RegisterAction(new Run(new Vector3(delta.x, 0, delta.z)));
                }else if(Level > 50){
                    //l'Agent cours loin de l'utilisateur
                    Agent.RegisterAction(new Say("I'm Scared"));
                    Agent.RegisterAction(new Push(delta, 50));
                }else if(Level > 25){
                    //l'Agent marche loin de l'utilisateur
                    Agent.RegisterAction(new Run(new Vector3(delta.x, 0, delta.z)));
                }
            }
            
        }
    }
}
