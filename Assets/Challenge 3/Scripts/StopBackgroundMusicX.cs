using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusicX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Stops the BGMusic if the player hits the obstacle
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
        }
    }
}
