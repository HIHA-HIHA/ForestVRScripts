using System.Collections;

using UnityEngine;

public class SpawnerItems : MonoBehaviour
{
    [SerializeField] private Item[] prefabsForSpawn;

    [SerializeField] private float delay;

    [SerializeField] private Transform spawnPoint;

    private bool canWork;

    public void StartSpawn()
    {
        canWork = true;
        StartCoroutine(CreateItems());
    }

    public void EndSpawn()
    {
        canWork = false;
    }

    private IEnumerator CreateItems()
    {
        while (canWork)
        {
            var ball = Instantiate(prefabsForSpawn[Random.Range(0, prefabsForSpawn.Length)], spawnPoint);
            ball.transform.parent = null;
            ball.transform.localRotation = spawnPoint.transform.localRotation;
            ball.transform.position = spawnPoint.transform.position;
            ball.transform.rotation = spawnPoint.rotation;
            PoolForDestroy.Instance.AddObject(ball.gameObject);
            yield return new WaitForSeconds(delay);
        }
    }

}
