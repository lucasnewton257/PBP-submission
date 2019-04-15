using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
    public float speed = .5f;
	// Update is called once per frame
	void Update () {
        Vector2 move = new Vector2(Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = move;
	}
}
