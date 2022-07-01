using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
public class AudioScript : MonoBehaviour
{
    public bool isMuted = false;
    [Range(0.0f , 1.0f)]
    [SerializeField]
    private float masterVolume = 1.0f;
    public Slider Volume;
    public AudioSource myMusic;

   void Update(){
   if(Input.GetKeyUp(KeyCode.DownArrow)){
        masterVolume = masterVolume - 0.1f;
        Volume.value = masterVolume;
        }
  if(Input.GetKeyUp(KeyCode.UpArrow)){
            masterVolume = masterVolume + 0.1f;
            Volume.value = masterVolume;
            }
    //if(Input.GetKeyUp(KeyCode.M)){
    //   if(isMuted){ 
            if(Input.GetKeyUp(KeyCode.M)){
				 myMusic.volume = 0f;
                 Volume.value = 0f;
				isMuted=true;
                    }
            if(Input.GetKeyUp(KeyCode.N)){     
				 myMusic.volume = masterVolume; 
                 Volume.value = masterVolume;
				isMuted=false;  
                }  
                                
   //myMusic.volume = Volume.value;
    if(!isMuted)
    myMusic.volume = masterVolume;  
    //AudioListener.volume = masterVolume;
   
   }
}