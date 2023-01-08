using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win1 : MonoBehaviour
{

    public Rigidbody playerRb1;
    public GameManager code;

    int collision_number=0;

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "winpoint")
        {
            if (collision_number < 1)
            {
                Debug.Log("TOUCH");
                collision_number +=1;
                code.win_number +=1;
            }

        }
    }
}
