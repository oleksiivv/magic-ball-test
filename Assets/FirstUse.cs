using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstUse : MonoBehaviour
{
    void Start(){
        if(PlayerPrefs.GetInt("studied")==0){
            gameObject.SetActive(true);
            Invoke(nameof(turnOf),7);
            PlayerPrefs.SetInt("studied",1);
        }
        else{
            gameObject.SetActive(false);
        }
    }


    void turnOf(){
        gameObject.SetActive(false);
    }
}
