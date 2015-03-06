using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Actions
{
    class Push : AIAction
    {
        public Vector3 Direction;
        public float Strength;

        public Push(Vector3 direction, float strength)
        {
            this.Direction = direction;
            this.Strength = strength;
        }

        public override bool Execute(AIAgent agent)
        {
            var rb = agent.GetComponent<Rigidbody>();
            rb.AddForce(this.Direction.normalized* this.Strength);
            return true;
        }
    }
}
