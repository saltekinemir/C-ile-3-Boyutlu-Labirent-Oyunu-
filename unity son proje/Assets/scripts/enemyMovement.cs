
using UnityEngine.SceneManagement;
using UnityEngine;


public class enemyMovement : MonoBehaviour
{
    public Rigidbody enemyRB;
    public float movespeed = 10.0f;
    public ParticleSystem enemyParticul;
    



    // Update is called once per frame
    void Update()
    {
        enemyParticul.Play();
        enemyRB.AddForce(movespeed * Time.deltaTime,0 , 0, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "unvisiblewall")
        {
            movespeed = - movespeed;
        }

        if (collisionInfo.collider.tag == "player")
        {
            SceneManager.LoadScene("Game Over");
        }  
    }

}
