using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadSceneDelay = 1;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasPlayed = false;
   

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") && !hasPlayed)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Debug.Log("ouch!");
            hasPlayed = true;
            Invoke("ReloadScene", reloadSceneDelay);
            
            
        }
    }
  void ReloadScene()
    {
        SceneManager.LoadScene(0);
        hasPlayed = false;

    }
}

