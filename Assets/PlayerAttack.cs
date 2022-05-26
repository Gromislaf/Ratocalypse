using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour

    
{
    public GameObject target;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        { Attack(); }
        if (Input.GetMouseButtonDown(0))
        {
            if (anim != null)
            {
                // play Bounce but start at a quarter of the way though
                anim.Play("Base Layer.attack");
            }
        }
    }
    private void Attack()
    {
        
        float distance = Vector3.Distance(target.transform.position, transform.position);
        Debug.Log(distance);
        if (distance < 2.5f)
        {
            EnemyHealth eh = (EnemyHealth)target.GetComponent("EnemyHealth");
            eh.AddjustCurrentHealth(-10);
            
        }
    } 
}
