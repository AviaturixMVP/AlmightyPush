using UnityEngine;

public class WeatherSpawner : MonoBehaviour
{
    Vector3 mousePos;
    public GameObject obj;

    [SerializeField] LayerMask weatherSpawnerlayer;

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Vector2.zero, mousePos, 200f, weatherSpawnerlayer);

            if(hit.collider != null)
            {
                obj.transform.position = hit.point;
            }

            Debug.DrawRay(Vector2.zero, mousePos * 5f, Color.red);
        }
    }
}
