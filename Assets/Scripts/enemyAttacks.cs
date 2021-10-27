using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class enemyAttacks : MonoBehaviour
{
    public GameObject[] attackPatterns;
    public GameObject activeAttack;
    public GameObject player;
    public float timer = timerScript.finalScore;
    public GameObject notActive;

    private void Start()
    {
            InvokeRepeating("AttackTime", 1.0f, 10.5f);
    }

   
    void AttackTime()
    {
        if (timerScript.finalScore <= 40f)
        {
            activeAttack = attackPatterns[Random.Range(2, 6)];
            activeAttack.SetActive(true);
            Instantiate(activeAttack, transform.position, transform.rotation);
            Invoke("removeCompleted", 10);
        }
        else if (timerScript.finalScore >40f)
        {
            activeAttack = attackPatterns[Random.Range(0, attackPatterns.Length)];
            activeAttack.SetActive(true);
            Instantiate(activeAttack, transform.position, transform.rotation);
            Invoke("removeCompleted", 10);
        }
        
    }

    void removeCompleted()
    {
        activeAttack.gameObject.tag = "Done";
        if (gameObject.tag == "Done")
        {
            Destroy(gameObject);
        }
        //activeAttack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
