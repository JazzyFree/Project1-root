using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {
        //get ray from main camera
        //check ray against plane for intersect
        // rotate to spot where they intersect

        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            Vector3 lookHere = ray.GetPoint(distance);

            transform.LookAt(new Vector3(lookHere.x, transform.position.y, lookHere.z));
        }
    }
}
