using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSphere : MonoBehaviour
{
    public List<string> answers = new List<string>();

    public Text answerField;
    public ParticleSystem answerEffect;

    private bool isRotating=true;

    public AudioSource source;
    void Update(){
        if(isRotating){
            //transform.Rotate(0,1,0);
        }
    }

    public static int addCnt=1;
    public AdmobController admob;

    public void ask(){
        if(IsInvoking(nameof(showAnswer)))return;
        
        isRotating=false;
        answerField.text="";
        answerEffect.Play();
        Invoke(nameof(showAnswer),1.5f);

        if(PlayerPrefs.GetInt("!sound")==0)source.Play();

        if(addCnt%5==0){
            admob.showIntersitionalAd();
        }
        addCnt++;
    }

    void showAnswer(){
        answerField.text=answers[Random.Range(0,answers.Count)];
        Invoke(nameof(resumeRotating),5f);

    }

    void resumeRotating(){
        isRotating=true;
    }


}
