using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField]
    private float spinSpeed;
    
 

    // Update is called once per frame
    void Update()
    {
	//spin the boi
        transform.Rotate(Vector3.right * spinSpeed, Space.Self);
    }
}
