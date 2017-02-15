using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public GameObject ball;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 startVelocity=new Vector3(0,0,0);
    private Vector3 startSize;
    public Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        startPosition = ball.transform.position;
        startRotation = ball.transform.rotation;
        startVelocity = ball.transform.localEulerAngles;
        startSize = ball.transform.localScale;
        rigidbody = GetComponent<Rigidbody>();
	}

    void ResetBall()
    {
        ball.transform.position = startPosition;
        ball.transform.rotation = startRotation;
        ball.transform.localScale = startSize;
        rigidbody.velocity = startVelocity;
    }
	// Update is called once per frame
	void Update ()
    {
        if (OVRInput.Get(OVRInput.Button.One)) ResetBall();
		
	}
}
