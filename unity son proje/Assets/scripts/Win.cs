using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour

{
    public Rigidbody playerRb;
    public GameManager code;
    int collision_number= 0;

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
