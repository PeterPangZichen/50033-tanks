using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip winSound; 
    private AudioSource source; 


    void Start () {
        source = GetComponent<AudioSource>();
    }
    
    public void play(){
        Debug.Log("test123");
        source.PlayOneShot(winSound, 1.0f);
    }
}