using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHeath = 100;
    public int curHealth = 100;
    public float healthBarLenght;
    // Start is called before the first frame update
    void Start()
    {
        healthBarLenght = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AddjustCurrentHealth(0);
    }
    void OnGUI()
    {
        GUI.Box(new Rect(10, 40, healthBarLenght, 20), curHealth + "/" + maxHeath);   
    }
    public void AddjustCurrentHealth(int adj)
    { curHealth += adj;
        if (curHealth < 0)
            curHealth = 0;
        if (curHealth > maxHeath)
            curHealth = maxHeath;
        if (maxHeath < 1)
            maxHeath = 1;
        healthBarLenght = (Screen.width / 2) * (curHealth / (float)maxHeath);
    }
}
