using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamescript : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject Gameoverpanel;

    // Start is called before the first frame update
    void Start()
    {
        Gameoverpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            //spawnObject.SetActive(false);
            //Gameoverpanel.SetActive(true);
            //SceneManager.LoadScene("Start");
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
