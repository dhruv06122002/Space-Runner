using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float PlayerSpeed;
    private Rigidbody2D rb;
    private Vector2 PlayerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float DirectionY = Input.GetAxisRaw("Vertical");
        PlayerDirection = new Vector2(0, DirectionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, PlayerDirection.y * PlayerSpeed);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collide");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
