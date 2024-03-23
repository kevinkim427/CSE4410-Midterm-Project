using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    [SerializeField] GameObject enemyPrefab;
    public GameObject enemy;
    public int enemycount = 10;

    KillCounter killcountscript;
    
    void Start()
    {
        killcountscript = GameObject.Find("Kills").GetComponent<KillCounter>();
        if (enemy == null)
        {
            for(int i= 0; i <= enemycount; i++)
            {
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(Random.Range(-90, 90), 5, Random.Range(-90, 90));
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(killcountscript.kills == enemycount)
        {
            Debug.Log("enemy null");
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");            
        }
    }
}
