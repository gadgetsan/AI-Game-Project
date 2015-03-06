using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {

        Player = GameObject.Find("FPSController");
        if (Player == null)
        {
            Player = GameObject.Find("OVRPlayerController");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Player != null)
        {
            transform.LookAt(this.transform.position + (this.transform.position - Player.transform.position));
        }
	}
}
