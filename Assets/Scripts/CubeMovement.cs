using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float forward_speed;
    [SerializeField] private float slide_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float slide = Input.GetAxis("Horizontal")*slide_speed*Time.deltaTime;
        this.transform.Translate(slide, 0, forward_speed * Time.deltaTime);
    }
}
