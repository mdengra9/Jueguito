using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    SFXManager sfxmanager;

    // Start is called before the first frame update
    void Awake()
    {
        sfxmanager = GameObject.Find ("SFXManager").GetComponent <SFXManager>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(this.gameObject);
        sfxmanager.Bullet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
