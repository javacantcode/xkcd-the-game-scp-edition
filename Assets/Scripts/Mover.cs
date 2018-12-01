using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Mover : MonoBehaviour {

    private MouseLook _mouseLook;

    public Transform camera;

	// Use this for initialization
	void Start () {
        _mouseLook = new MouseLook();
        _mouseLook.clampVerticalRotation = false;
        _mouseLook.Init(this.transform, camera);


    }
	
	// Update is called once per frame
	void Update () {

        _mouseLook.LookRotation(this.transform, camera);

    }

    private void FixedUpdate()
    {
        _mouseLook.UpdateCursorLock();
    }
}
