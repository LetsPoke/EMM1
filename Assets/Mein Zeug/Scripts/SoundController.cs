using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }
    
    void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag.Equals("coin")){
        source.Play();
        }
    }
}
