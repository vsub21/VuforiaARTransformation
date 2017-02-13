using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTransformV2 : MonoBehaviour {

    private bool isRotating = false;
    private bool isTranslating = false;
    private bool isScaling = false;

    Transform mTargetTransform = null;

    GameObject target;

    GameObject other;
    Camera camera;

    Vector3 offset;

    // Use this for initialization
    void Start () {
        other = GameObject.FindGameObjectWithTag("MainCamera");
        camera = other.GetComponent<Camera>();

        target = GameObject.Find("ImageTarget");
    }
	
	// Update is called once per frame
	void Update () {

        if (target == null)
            target = GameObject.Find("ImageTarget");

        if (isTranslating)
        {
            Debug.Log("isTranslating...");
            Vector3 ttp = camera.WorldToViewportPoint(target.transform.position);
            transform.position = camera.ViewportToWorldPoint(ttp + offset);
        }

        else if (isRotating)
        {
            Debug.Log("isRotating...");
        }
        
        else if (isScaling)
        {
            Debug.Log("isScaling...");
        }
        
    }

    public void toggleTranslating()
    {
        Debug.Log("called toggleTranslating()");
        if (isTranslating)
        {
            Debug.Log("setting isTranslating to false");
            isTranslating = false;
        }
        else
        {
            Debug.Log("setting isTranslating to true");
            isTranslating = true;
            isRotating = false;
            isScaling = false;

            Vector3 cubeViewPort = camera.WorldToViewportPoint(transform.position);
            Debug.Log("cube is " + cubeViewPort + "triple away from origin");

            Vector3 targetViewPort = camera.WorldToViewportPoint(target.transform.position);
            Debug.Log("target is " + targetViewPort + "triple away from origin");

            offset = cubeViewPort - targetViewPort;
            Debug.Log("Offset is " + offset);
            Debug.Log("Done toggling");
        }
    }

    public void toggleRotating()
    {
        Debug.Log("called toggleRotating()");
        if (isRotating)
        {
            Debug.Log("setting isRotating to false");
            isRotating = false;
        }
        else
        {
            Debug.Log("setting isRotating to true");
            isTranslating = false;
            isRotating = true;
            isScaling = false;
        }
    }

    public void toggleScaling()
    {
        Debug.Log("called toggleScaling()");
        if (isScaling)
        {
            Debug.Log("setting isScaling to false");
            isScaling = false;
        }
        else
        {
            Debug.Log("setting isScaling to rtue");
            isTranslating = false;
            isRotating = false;
            isScaling = true;
        }
    }
}
