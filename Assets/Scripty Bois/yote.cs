using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yote : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)) {
            anim.SetBool("walking", true);
        }
	}
}
