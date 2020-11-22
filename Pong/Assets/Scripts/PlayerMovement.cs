using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mousePosition;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.localPosition =  new Vector3(transform.localPosition.x, Mathf.Clamp(mousePosition.y, -3.8f, 3.8f), transform.localPosition.z);

       // transform.localPosition = new Vector3(transform.localPosition.x, mousePosition.y, transform.localPosition.z);
    }



}
