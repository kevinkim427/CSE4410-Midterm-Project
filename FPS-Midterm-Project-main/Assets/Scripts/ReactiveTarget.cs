using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    
    KillCounter killcountscript;
    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null )
        {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    public IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
        killcountscript.addKills();
    }

    

    // Start is called before the first frame update
    void Start()
    {
        killcountscript = GameObject.Find("Kills").GetComponent<KillCounter>();      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
