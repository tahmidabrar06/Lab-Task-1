using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer rd;
    private float time;
    void Start()
    {
        rd = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 3)
        {
            RandomizeColor();
            time = 0;
        }
    }

    void RandomizeColor()
    {
        rd.material.color = new Color(Random.Range(0.4f, 1f),Random.Range(0.4f, 1f),Random.Range(0.4f, 1f));
    }
}
