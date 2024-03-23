using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;
    [SerializeField] TMP_Text healtLabel;
    
    void Start()
    {
        health = 10;
    }

    public void Hurt(int damage)
    {
        health -= 1;
        healtLabel.text = $"Player Health: {health}";
    }
    // Update is called once per frame
    void Update()
    {
        if (health <=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
