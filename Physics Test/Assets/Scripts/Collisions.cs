using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {

    public OVRInput.Controller RightController;
    public OVRInput.Controller LeftController;
    public Rigidbody ball;

    void OnCollisionEnter(Collision col)
    {
       if(col.gameObject.name=="Right Hand") GetComponent<Rigidbody>().AddForce(OVRInput.GetLocalControllerVelocity(RightController)*100);
        if (col.gameObject.name == "Left Hand") GetComponent<Rigidbody>().AddForce(OVRInput.GetLocalControllerVelocity(LeftController)*100);
    }

}
