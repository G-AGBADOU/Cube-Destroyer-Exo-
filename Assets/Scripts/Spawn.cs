using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour

{
    public GameObject cube;
    public float xPos = 1;
    public float yPos = 5;
    public int zPos = 1;
    public int cubecount;
    [SerializeField] float distance;
    [SerializeField] float vitess;
   // public float randomPosXYZ;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(EnemyDrop());

        InvokeRepeating("LaunchProjectile", 2.0f, 3.0f);
    }


   


   /* IEnumerator EnemyDrop()
    {
        while (cubecount < 10)
        {
            xPos = Random.Range(0f, 1f);
            yPos = Random.Range(0f, 1f);
            Instantiate(cube, new Vector3(xPos, yPos, 5.1f), Quaternion.identity);
            yield return new WaitForSceonds(0.3f);
           cubecount += 1;

           // Debug.Log ()
        }
    }*/


    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchProjectile()
    {
        xPos = Random.Range(0f, 4f);
        yPos = Random.Range(0f, 5f);
        Instantiate(cube, new Vector3(xPos, yPos, 5.1f), Quaternion.identity);
        //yield return new WaitForSceonds(0.3f);
        cubecount += 1;
    }
}
