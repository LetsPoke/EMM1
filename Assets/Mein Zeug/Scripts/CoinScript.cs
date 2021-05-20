using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{   
    private float angle = 0;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        angle++;
        this.transform.rotation = Quaternion.Euler(new Vector3(90f,angle/2,0f));
    }
    private void OnTriggerEnter(Collider other) {
        //StartCoroutine(WaitForSeconds());
         if(other.gameObject.tag.Equals("Player")){
        Destroy(gameObject);
        }
        
    }
    //private IEnumerator WaitForSeconds(){
    //    yield return new WaitForSeconds(1f);
    //    Destroy(gameObject);
    //}
}
