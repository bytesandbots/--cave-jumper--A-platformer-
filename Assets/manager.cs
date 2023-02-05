using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour
{
    public int coinscollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("coin").Length <= 0)
        {
            SceneManager.LoadScene("win");
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
