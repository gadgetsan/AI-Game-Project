using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class AICharacteristic
{
    public int Modifier;
    public AIAgent Agent;
    public int Level;
    public List<string> PossibleValues;
    public List<AIAction> PossibleActions;
    public List<GameEvent> PossibleEvents;
    public List<AIState> PossibleStates;

    public AICharacteristic()
    {

    }

    public AICharacteristic(AIAgent agent)
    {
        this.Agent = agent;
    }

    public abstract void React(GameEvent theEvent);
}