﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Actions
{
    class Run : AIAction
    {
        public Vector3 Destination;

        public Run(Vector3 destination)
        {
            this.Destination = destination;
        }

        public override bool Execute(AIAgent agent)
        {
            var rb = agent.GetComponent<Rigidbody>();
            rb.MovePosition(rb.position + this.Destination);
            return true;
        }
    }
}
