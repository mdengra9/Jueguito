using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    BoxCollider2D boxCollider;

    SFXManager sfxManager;
    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        sfxManager = GetComponent<SFXManager>();
        soundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("Player Dead");
            Destroy(collider.gameObject);
            soundManager.StopBGM();
            sfxManager.PlayerDeath();
            SceneManager.LoadScene(2);
        }
    }
}
