using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerDeath;
    public AudioClip bullet;
    public AudioClip shot;

    private AudioSource source;

  public void PlayerDeath() 
    {
        source.PlayOneShot(playerDeath);
    }

  public void Bullet() 
    {
        source.PlayOneShot(bullet);
    }

  public void Shot() 
    {
        source.PlayOneShot(shot);
    }
}
