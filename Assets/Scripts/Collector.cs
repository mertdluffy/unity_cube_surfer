using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collector : MonoBehaviour
{

    public GameObject mainCube;
    int height;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        Console.Write(height);
        mainCube.transform.position = new Vector3(transform.position.x, (float)(height+0.5), transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void decreaseHeight()
    {
        height--;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && !other.gameObject.GetComponent<CollectableCube>().getIsCollected()) {
            height += 1;
            other.gameObject.GetComponent<CollectableCube>().markAsCollected();
            other.gameObject.GetComponent<CollectableCube>().setIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
