using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int hitCount = 0;

    public void Hit()
    {
        if (hitCount < 9)
        {
            transform.localScale *= 0.9f;
            hitCount += 1;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
