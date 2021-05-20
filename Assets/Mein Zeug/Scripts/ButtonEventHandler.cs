using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] Transform player;
    private float angle;
    private bool bup, bdown, bright, bleft;
    
    
    void Start(){
        //Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i=0 ;i < vbs.Length; i++){
            //RegisterwiththevirtualbuttonsTrackableBehaviour
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }
    void Update(){
        if(bup){
            player.position += 1 * movementSpeed * player.forward;
        }
        if(bdown){
            player.position += -1 * movementSpeed * player.forward;
        }
        if(bright){
            angle += 0.01f;
            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));
            player.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
        if(bleft){
            angle -= 0.01f;
            Vector3 targetDirection2 = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));
            player.transform.rotation = Quaternion.LookRotation(targetDirection2);
        }
    }
    
    ///<summary>
    ///Calledwhenthevirtualbuttonhasjustbeenpressed:
    ///</summary>
    public void OnButtonPressed(VirtualButtonBehaviour vbs){
        switch (vbs.VirtualButtonName){
            case "ButtonUp" :
            bup = true;
            break;
            case "ButtonDown" :
            bdown = true;
            break;
            case "ButtonRight" :
            bright = true;
            break;
            case "ButtonLeft" :
            bleft = true;
            break;
        }
    }
    
    ///<summary>
    ///Calledwhenthevirtualbuttonhasjustbeenreleased:
    ///</summary>
    public void OnButtonReleased(VirtualButtonBehaviour vbs){
        switch (vbs.VirtualButtonName){
            case "ButtonUp" :
            bup = false;
            break;
            case "ButtonDown" :
            bdown = false;
            break;
            case "ButtonRight" :
            bright = false;
            break;
            case "ButtonLeft" :
            bleft = false;
            break;
        }
    }
}
