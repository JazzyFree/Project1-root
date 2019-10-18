using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollow : MonoBehaviour {

    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;
		
	}
	
	// LateUpdate is called after update methonds 
	void LateUpdate () {
        Vector3 newPos = PlayerTransform.position + _cameraOffset;
        //to have a smooth camera move
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer)
            transform.LookAt(PlayerTransform);
	}
}
