using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    private int lifeAmount;
    private bool isDead;

    private void Start()
    {
        lifeAmount = hearts.Length;

    }
    private void Update()
    {
        if(isDead)
        {
            Destroy(this.gameObject);
        }

    }

    public void TakeDamage(int damageAmount)
    {
        lifeAmount -= damageAmount;
        Destroy(hearts[lifeAmount].gameObject);

        if (lifeAmount < 1)
        {
            isDead = true;
            SceneManager.LoadScene("DeathScene");

        }

    }

}
