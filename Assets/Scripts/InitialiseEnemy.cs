using System.Collections;
using UnityEngine;

public class InitialiseEnemy : MonoBehaviour
{

    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform waypoint;

    //Enemies Array
    [SerializeField]
    private GameObject[] enemies;

    float timer;
    public float interval = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    [SerializeField]
    public int enemyCount = 30;

    //public int i;
    private void Start()
    {

        //for (i = 0; i < enemyCount; i++)
        //{
        //    //instantiate a random enemy

        //    int x = Random.Range(0, 5);

        //    GameObject enemy = Instantiate(enemies[x], waypoint.transform.position, Quaternion.identity);
        //    //enemy.GetComponent<FollowPath>().Setwaypoints();
        //    StartCoroutine(Order());

        //}
        timer = 0f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);
        if (timer <= 0 && enemyCount > 0)
        {
            int ran = Random.Range(0, 5);
            Instantiate(enemies[ran], waypoint.transform.position, Quaternion.identity);
            enemyCount--;
            timer = interval;
        }
    }

    IEnumerator Order()
    {
        // transform.Rotate(90, 0, 0);


        yield return new WaitForSeconds(3.0f);
        //transform.Translate(1, 0, 0);
    }

}