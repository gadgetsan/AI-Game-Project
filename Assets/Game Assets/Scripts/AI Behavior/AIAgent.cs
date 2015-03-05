using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Characteristics;

public class AIAgent : InteractableElement {

    public List<AIState> States;
    public List<AICharacteristic> Characteristics;
    public List<Vector3> PreviousPositions;

    public string Name;

    void Awake()
    {
        Characteristics = new List<AICharacteristic>();
        States = new List<AIState>();
        PreviousPositions = new List<Vector3>();
        Debug.Log("Ready");
    }
	// Use this for initialization
	void Start () {
	    //pour fin de test on va ajouter une caractéristique à cet Agent
        this.Name = "Bob";
        AICharacteristic myFirstCharacteristic = new Scaredy(this);
        this.Characteristics.Add(myFirstCharacteristic);
	}


    void OnTriggerEnter()
    {
        //on créé l'évènement qui va faire que l'AI va avoir peur
        GameEvent ge = new GameEvent();
        ge.Type = "Vision";
        foreach (var charac in Characteristics)
        {
            charac.React(ge);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
