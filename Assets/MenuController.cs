using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menu;

    public Animator menuAnim;
    private int showCnt=0;

    public MusicController music;


    public GameObject unmutedSound, mutedSound;

    void Awake(){
        updateMusic();
    }

    public void mute(){
        PlayerPrefs.SetInt("!sound",1);
        updateMusic();
    }

    public void unmute(){
        PlayerPrefs.SetInt("!sound",0);
        updateMusic();
    }

    public void updateMusic(){
        if(PlayerPrefs.GetInt("!sound")==0){
            unmutedSound.SetActive(true);
            mutedSound.SetActive(false);
            music.source.enabled=true;
        }
        else{
            unmutedSound.SetActive(false);
            mutedSound.SetActive(true);
            music.source.enabled=false;
        }
    }

    public void showMenu(){
        
        
        menu.SetActive(true);
        menuAnim.SetBool("hide",showCnt%2==1);
        showCnt++;
        
        
    }


    //


    public void rate(){
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Vertex+Studio+Games");
    }

    public void exit(){
        Application.Quit();
    }

}
