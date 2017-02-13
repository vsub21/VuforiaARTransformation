using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour {

    // Fix security issues

    bool rotLock;
    bool transLock;
    bool scaleLock;

    Transform mTargetTransform = null;

    GameObject other;
    Camera camera;

    Vector3 absPos;
    Vector3 offset;
    Vector3 targetLastPos;

    // Use this for initialization
    void Start () {
        Debug.Log("Started Script2");

        transLock = false;
        rotLock = false;
        scaleLock = false;

        other = GameObject.FindGameObjectWithTag("MainCamera");
        camera = other.GetComponent<Camera>();

        absPos = camera.WorldToViewportPoint(transform.position);
        offset = transform.position - camera.transform.position;

        GameObject target = GameObject.Find("ImageTarget");
        if (target != null)
        {
            Debug.Log("Target found");
            mTargetTransform = target.transform;
        }
        targetLastPos = mTargetTransform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 cubeViewPort = camera.WorldToViewportPoint(transform.position);
        Debug.Log("cube is " + cubeViewPort + "triple away from origin");

        Vector3 targetViewPort = camera.WorldToViewportPoint(mTargetTransform.position);
        Debug.Log("target is " + targetViewPort + "triple away from origin");

        if (rotLock)
        {
            camera.transform.LookAt(transform);
        }
	}

    public void toggleRotateLock()
    {
        Debug.Log("called toggleRotateLock()");
        if (rotLock)
        {
            Debug.Log("setting rotLock to true");
            rotLock = false;
        }
        else
        {
            Debug.Log("setting rotLock to false");
            rotLock = true;
        }
    }
}
