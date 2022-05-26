using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public int maxDistance;
    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        maxDistance = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(target.position, myTransform.position, Color.yellow );
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
        if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
        {
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
