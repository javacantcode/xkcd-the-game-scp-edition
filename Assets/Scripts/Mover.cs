using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Mover : MonoBehaviour {

    private MouseLook _mouseLook;

    public Transform camera;

    public Animator animator;

	// Use this for initialization
	void Start () {
        _mouseLook = new MouseLook();
        _mouseLook.clampVerticalRotation = false;
        _mouseLook.Init(this.transform, camera);


    }
	
	// Update is called once per frame
	void Update () {

        _mouseLook.LookRotation(this.transform, camera);

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetFloat("WalkSpeed", 0.3f);
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Vertical") > 0)
        {
            animator.SetFloat("WalkSpeed", 0.5f);

        }
        else
        {

            //Stop running
            animator.SetFloat("WalkSpeed", 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Play attack animation
            animator.Play("priest_attack1");
            //watch the camera here, the attack move takes it further away, we should move the camera little closer here, or bring the camera into the heirarchy?
        }

    }

    private void FixedUpdate()
    {
        _mouseLook.UpdateCursorLock();
    }
}
