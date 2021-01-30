using UnityEngine;

public class SpawnSchnee : MonoBehaviour
{
    public GameObject schneePrefab;
    public GameObject parentSpawnGo;

    private float spawnRate = 1f;
    private float nextSpawn = 2f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTheSnow();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheSnow();
            
        }
    }
    private void SpawnTheSnow()
    {
        var clones = Instantiate(schneePrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0) ;
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3 (1f, 1f, 1f);
    }
}
