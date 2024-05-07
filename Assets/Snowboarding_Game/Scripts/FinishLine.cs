using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadSceneDelay = 1;
    [SerializeField] ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Debug.Log("Finished!");
            Invoke("ReloadScene", reloadSceneDelay);


        }

    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
