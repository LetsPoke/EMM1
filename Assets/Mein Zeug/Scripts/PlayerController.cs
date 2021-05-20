using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float movementSpeed = 0f;

    private float angle;
    public int score = 0;
    [SerializeField] public Text scoreText;
    
    
    void Start(){
        transform.position = new Vector3(0f,1f,0f);
        scoreText.text = "Score: 0";
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        angle += moveHorizontal*0.02f;
        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));

        transform.localRotation = Quaternion.LookRotation(targetDirection);
        
        transform.position += moveVertical * movementSpeed * transform.forward;


        if (Input.GetKeyDown("space")){
            this.transform.localRotation = Quaternion.Euler(new Vector3(0f,0f,0f));
        }
        
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("coin")){
        score++;
        Debug.Log(score);
        }
        
    }

}
