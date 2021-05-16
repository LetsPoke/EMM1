using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterHunter : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float movementSpeed = 0.1f;
    public PlayerController score;
    private int tempScore;

    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
        tempScore = score.score;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);

        if(score.score > 0){
            transform.position += transform.forward*movementSpeed;
        }
        
        if(tempScore != score.score){
        transform.localScale += scaleChange;
        tempScore++;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag.Equals("Player")){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
