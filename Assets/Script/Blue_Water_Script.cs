using UnityEngine;

public class Blue_Water_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedGirl") && !GameManager.gameManager.isPlayerDead)
        {
            Destroy(other.gameObject);
        }
    }
}
