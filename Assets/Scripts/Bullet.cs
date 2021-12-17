using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<Score>().scoreNum++;
            BasicPool.Instance.AddToPool(gameObject);
            Destroy(collision.gameObject);
        }
        else
        {
            BasicPool.Instance.AddToPool(gameObject);
        }
    }
}