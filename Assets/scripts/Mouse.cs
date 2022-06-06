using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public int pollen;
    Vector2 MousePos;
    public List <Transform> Points = new List<Transform>(20);
    public List <GameObject> Flowers = new List<GameObject>(4);
    public List <GameObject> Now_Flowers = new List<GameObject>(20);
    public int count = 0;
    public int count2 = 0;
    public float SpawnRate = 0.5f;
    public float NextSpawn = 0.0f;
    public GameObject effect;
    

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {

        print(Time.time);
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = MousePos;    

        while (count < 40 && Time.time >= NextSpawn)
        {
            if (Now_Flowers[count] == null)
            {
                Now_Flowers[count] = Instantiate(Flowers[Random.Range(0, 4)], Points[count].position, Points[count].rotation);
                NextSpawn = Time.time + SpawnRate;
            }
            
            count += 1;
        }

        if (count2 > 39)
        {
            count2 = 0;
        }                      

        if (Now_Flowers[count2].transform.localScale.y < 1 && Now_Flowers[count2].transform.localScale.y < 1 && Time.time >= NextSpawn)
        {
            Now_Flowers[count2].transform.localScale += new Vector3(0.25f, 0.25f, 0.0f);
            NextSpawn = Time.time + SpawnRate;
        }
        count2 ++;
        
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            pollen += 1;
            gameObject.GetComponent<Menu>().PollenSetup(pollen);
            other.gameObject.transform.localScale -= new Vector3(0.25f, 0.25f, 0.0f);
            Destroy(Instantiate(effect, new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, -20f) , transform.rotation), 2f);
        }
    }

    
}
