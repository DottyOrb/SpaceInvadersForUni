using UnityEngine;

public class VanSpawning : MonoBehaviour
{
    public GameObject MysteryShipRight;
    public GameObject MysteryShipLeft;
    public float timeTillSpawn = 20;

    private void Update()
    {
        if (timeTillSpawn > 0)
        {
            timeTillSpawn -= Time.deltaTime;
        }
        else
        {
            int RandomSpawn = Random.Range(0, 2);
            if (RandomSpawn == 0)
            {
                Instantiate(this.MysteryShipRight);
                timeTillSpawn = 20;
            }
            else if (RandomSpawn == 1)
            {
                Instantiate(this.MysteryShipLeft);
                timeTillSpawn = 20;
            }
        }
    }
}
