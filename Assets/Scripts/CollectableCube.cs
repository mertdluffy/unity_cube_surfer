using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;
    int index;
    public Collector collector;
    // Start is called before the first frame update
    void Start()
    {
        isCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollected) { 
            if (transform.parent != null) {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            collector.decreaseHeight();
        }
    }

    
    public bool getIsCollected() {
        return isCollected;
    }

    public void markAsCollected()
    {
        isCollected = true;
    }
    
    public void setIndex(int index)
    {
        this.index = index;

    }
}
