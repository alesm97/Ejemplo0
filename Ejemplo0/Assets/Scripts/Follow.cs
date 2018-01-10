using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //distancia entre player y camara
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
