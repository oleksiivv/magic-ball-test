using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource source;

    void Start(){
        source.enabled=false;
        source.clip=clips[Random.Range(0,clips.Length)];
        source.enabled=PlayerPrefs.GetInt("!sound")==0;
    }
}
