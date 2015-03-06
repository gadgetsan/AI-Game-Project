using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Actions
{
    class Say : AIAction
    {
        public string Text;

        public Say(string text)
        {
            this.Text = text;
        }

        public override bool Execute(AIAgent agent)
        {
            agent.transform.FindChild("Speech").GetComponent<TextMesh>().text = Text;
            return true;
        }
    }
}
