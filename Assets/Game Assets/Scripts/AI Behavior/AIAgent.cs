using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Characteristics;

public class AIAgent : InteractableElement {

    public List<AIState> States;
    public List<AICharacteristic> Characteristics;
    public List<Vector3> PreviousPositions;

    public List<AIAction> Actions;

    public string Name;


    void Awake()
    {
        Characteristics = new List<AICharacteristic>();
        States = new List<AIState>();
        PreviousPositions = new List<Vector3>();
        Actions = new List<AIAction>();

        //on va aller chercher l'enfant qui s'appel 'Speech' qui est en fait l'objet de parole

        Debug.Log("Ready");
    }
	// Use this for initialization
	void Start () {
	    //pour fin de test on va ajouter une caractéristique à cet Agent
        this.Name = "Bob";
        AICharacteristic myFirstCharacteristic = new Scaredy(this);
        myFirstCharacteristic.Level = 55;
        this.Characteristics.Add(myFirstCharacteristic);
	}


    void OnTriggerStay(Collider other)
    {
        //on créé l'évènement qui va faire que l'AI va avoir peur
        GameEvent ge = new GameEvent(other);
        ge.Type = "Close";
        foreach (var charac in Characteristics)
        {
            charac.React(ge);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Actions.Count < 1)
        {
            return;
        }
        //on execute tant qu'elle ne retourne pas 'false' pour dire qu'elle est terminée
        if (Actions[0].Execute(this))
        {
            Actions.RemoveAt(0);
        }
	}

    public void RegisterAction(AIAction action)
    {
        Actions.Add(action);
    }
}
