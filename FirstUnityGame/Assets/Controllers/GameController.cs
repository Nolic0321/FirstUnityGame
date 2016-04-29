using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject player;
    public float speed;
    // Use this for initialization
    void Start () {
        speed = .05F;
	}
	
	// Update is called once per frame
	void Update () {
        player.transform.Translate(new Vector3(0, 0, 1*speed));
	}
}
