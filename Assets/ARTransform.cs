using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTransform : MonoBehaviour {

    Vector3 tempPos;
    Vector3 tempRot;
    Vector3 tempSca;

    // ******Fix security issues

    int xPos;
    int yPos;
    int zPos;

    int xRot = 0;
    int yRot = 0;
    int zRot = 0;

    int xSca = 0;
    int ySca = 0;
    int zSca = 0;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Start started");
        tempPos = transform.position;
        xPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Start Update Cycle; Pos = " + xPos + "," + yPos + "," + zPos);
        if (xPos > 0)
        {
            Debug.Log("Point x1");
            tempPos = transform.position;
            tempPos.x += 0.001f;
            transform.position = tempPos;
        }
        else if (xPos < 0)
        {
            Debug.Log("Point x2");
            tempPos = transform.position;
            tempPos.x -= 0.001f;
            transform.position = tempPos;
        }

        if (yPos > 0)
        {
            Debug.Log("Point y1");
            tempPos = transform.position;
            tempPos.y += 0.001f;
            transform.position = tempPos;
        }
        else if (yPos < 0)
        {
            Debug.Log("Point y2");
            tempPos = transform.position;
            tempPos.y -= 0.001f;
            transform.position = tempPos;
        }

        if (zPos > 0)
        {
            Debug.Log("Point z1");
            tempPos = transform.position;
            tempPos.z += 0.001f;
            transform.position = tempPos;
        }
        else if (zPos < 0)
        {
            Debug.Log("Point z2");
            tempPos = transform.position;
            tempPos.z -= 0.001f;
            transform.position = tempPos;
        }

        Debug.Log("End Update Cycle; Pos = " + xPos + "," + yPos + "," + zPos);
    }

    /// <summary>
    /// Translation functions below:
    /// </summary>
    public void XPosPlus()
    {
        /*
        Debug.Log("+ x pos");
        tempPos = transform.position;
        Debug.Log(tempPos);
        tempPos.x += 0.01f;
        transform.position = tempPos;
        */
        
        if (xPos > 0)
        {
            Debug.Log("+X (if xPos > 0): xPos is " + xPos);
            xPos = 0;
        }
        else
        {
            Debug.Log("+X (else): xPos is " + xPos);
            xPos = 1;
        }
        
    }

    public void XPosMinus()
    {
        /*
        tempPos = transform.position;
        tempPos.x -= 0.01f;
        transform.position = tempPos;
        */

        if (xPos < 0)
        {
            Debug.Log("-X (if xPos < 0): xPos is " + xPos);
            xPos = 0;
        }
        else
        {
            Debug.Log("-X (else): xPos is " + xPos);
            xPos = -1;
        }
    }

    public void YPosPlus()
    {
        /*
        tempPos = transform.position;
        tempPos.y += 0.01f;
        transform.position = tempPos;
        */

        if (yPos > 0)
        {
            Debug.Log("+Y (if yPos > 0): yPos is " + yPos);
            yPos = 0;
        }
        else
        {
            Debug.Log("+Y (else): yPos is " + yPos);
            yPos = 1;
        }
    }

    public void YPosMinus()
    {
        /*
        tempPos = transform.position;
        tempPos.y -= 0.01f;
        transform.position = tempPos;
        */

        if (yPos < 0)
        {
            Debug.Log("-Y (if yPos > 0): yPos is " + yPos);
            yPos = 0;
        }
        else
        {
            Debug.Log("-Y (else): yPos is " + yPos);
            yPos = -1;
        }
    }

    public void ZPosPlus()
    {
        /*
        tempPos = transform.position;
        tempPos.z += 0.01f;
        transform.position = tempPos;
        */

        if (zPos > 0)
        {
            Debug.Log("+Z (if zPos > 0): zPos is " + zPos);
            zPos = 0;
        }
        else
        {
            Debug.Log("+Z (else): zPos is " + zPos);
            zPos = 1;
        }
    }

    public void ZPosMinus()
    {
        /*
        tempPos = transform.position;
        tempPos.z -= 0.01f;
        transform.position = tempPos;
        */

        if (zPos < 0)
        {
            Debug.Log("-Z (if zPos < 0): zPos is " + zPos);
            zPos = 0;
        }
        else
        {
            Debug.Log("-Z (else): zPos is " + zPos);
            zPos = -1;
        }
    }

    /// <summary>
    /// Rotation functions below:
    /// </summary>
    public void XRotPlus()
    {

    }

    public void XRotMinus()
    {
        
    }

    public void YRotPlus()
    {

    }

    public void YRotMinus()
    {

    }

    public void ZRotPlus()
    {

    }

    public void ZRotMinus()
    {

    }

    /// <summary>
    /// Scaling functions below:
    /// </summary>
    public void XScaPlus()
    {

    }

    public void XScaMinus()
    {

    }

    public void YScaPlus()
    {

    }

    public void YScaMinus()
    {

    }

    public void ZScaPlus()
    {

    }

    public void ZScaMinus()
    {

    }


}
