using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Borders")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Debug.Log("collide");
            SceneManager.LoadScene("GameOver");
            //Destroy(player.gameObject);
        }
    }
}
