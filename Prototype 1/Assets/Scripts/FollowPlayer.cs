using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private float cameraSwitcher = 1.0f;
    private float angle = 18.55f;
    private float angle2 = 69.0f;
    private float angle3 = 0f;
    private float temp2;
    private Vector3 temp; 
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 30, 0);
    private Vector3 offset3 = new Vector3(0, 2.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offsets the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset1;
        transform.eulerAngles = new Vector3(angle, 0);

        if (Input.GetKeyDown(KeyCode.C) == true)
        {
            if(cameraSwitcher == 1.0f)
            {
                temp = offset1;
                offset1 = offset2;



                cameraSwitcher = 2.0f;
            }
            
            if(cameraSwitcher == 2.0f)
            {

                offset2 = offset3;
                
                cameraSwitcher = 3.0f;
            }

            if(cameraSwitcher == 3.0f)
            {

                offset3 = temp;
                
                cameraSwitcher = 1.0f;
            }
           
        }


    }
}
