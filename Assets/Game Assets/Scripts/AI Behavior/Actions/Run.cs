using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actions
{
    class Run : AIAction
    {
        public override bool Execute(AIAgent agent)
        {
            agent.transform.Translate(new UnityEngine.Vector3(-1, 0, -1));
            return true;
        }
    }
}
