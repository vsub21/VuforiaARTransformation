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

    Quaternion relativeRot;

    Vector3 initTargetPos;
    Vector3 initCubePos;
    Vector3 currentTargetPos;
    
    Vector3 oldScale;
    Vector3 initScale;

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

            transform.rotation = relativeRot * Quaternion.Inverse(target.transform.localRotation);

        }
        
        else if (isScaling)
        {
            Debug.Log("isScaling...");
            currentTargetPos = camera.WorldToViewportPoint(target.transform.position);

            float delta_x;

            delta_x = Mathf.Abs(currentTargetPos.x - initCubePos.x) - Mathf.Abs(initTargetPos.x - initCubePos.x);
            transform.localScale = initScale + new Vector3(delta_x, delta_x, delta_x);
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

            Vector3 cubeViewPort = camera.WorldToViewportPoint(transform.position);
            Debug.Log("cube is " + cubeViewPort + "triple away from origin");

            Vector3 targetViewPort = camera.WorldToViewportPoint(target.transform.position);
            Debug.Log("target is " + targetViewPort + "triple away from origin");

            Debug.Log("Offset is " + offset);

            relativeRot = target.transform.localRotation * transform.localRotation;
        }
    }

    public void toggleScaling()
    {
        Debug.Log("called toggleScaling()");
        if (isScaling)
        {
            Debug.Log("setting isScaling to false");
            isScaling = false;
            // isFirstRunScale = true;
        }
        else
        {
            Debug.Log("setting isScaling to rtue");
            isTranslating = false;
            isRotating = false;
            isScaling = true;

            initTargetPos = camera.WorldToViewportPoint(target.transform.position);
            initScale = transform.localScale;
            initCubePos = transform.position;
        }
    }

    public void reset()
    {
        isTranslating = false;
        isRotating = false;
        isScaling = false;

        transform.position = new Vector3(0.0042f, 0.05299997f, 0.0397f);
        transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.localScale = new Vector3(0.08842495f, 0.08842495f, 0.08842495f);
    }
}
