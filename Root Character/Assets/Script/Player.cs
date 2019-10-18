using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Player Max Speed
    private float speed = 3f;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
		
	
	
	private void Update() {
        Move();
        Jump();
		
	}
    void Move()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        // Max value for animation in direction
        input = Vector3.ClampMagnitude(input, 1f);
        // affect the speed

        input *= speed;

        animator.SetFloat("Horizontal",input.x);
        animator.SetFloat("Vertical",input.z);

   
    }
    void Jump()
    {   // set it to be true 

        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetTrigger("Jump");
    }

    //add crouch animation

}
