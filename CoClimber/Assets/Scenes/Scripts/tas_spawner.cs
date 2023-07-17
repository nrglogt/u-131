using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tas_spawner : MonoBehaviour
{
    public GameObject random_tas_npc;
    bool can_spawn = true;
    void Start()
    {
        StartCoroutine(Bekle());
    }

    IEnumerator Bekle()
    {
        while (can_spawn == true)
        {
            yield return new WaitForSeconds(4f);
            float respawnY = 100f; // Y düzleminde rastgele bir respawn değeri a
            Vector3 respawnPosition = new Vector3(transform.position.x, transform.position.y + 10, 0);
            GameObject npc = Instantiate(random_tas_npc, respawnPosition, Quaternion.identity);
            Destroy(npc, 10f); // 6 saniye sonra örneği yok et

        }


    }
}
