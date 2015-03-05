using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class AIAction
{
    public string Title;

    public abstract bool Execute(AIAgent agent);
}