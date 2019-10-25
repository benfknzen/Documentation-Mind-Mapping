using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Node : MonoBehaviour
{
    public GameObject Node;

    public void _click_Apply()
    {
        createNode();
    }

    private void createNode()
    {
        GameObject x = UnityEngine.Object.Instantiate(Node);
        x.transform.position = new Vector3(-1,-1,-1);
        //        x.transform.localScale = new Vector3(2, 2, 2);
        Debug.Log("node created");

    }
}
