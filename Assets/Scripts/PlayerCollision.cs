using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    public PlayerMovement movement;
    

    public void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
