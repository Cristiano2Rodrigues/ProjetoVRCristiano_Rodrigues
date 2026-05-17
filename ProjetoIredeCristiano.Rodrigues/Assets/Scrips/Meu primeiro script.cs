using UnityEngine;

public class Meuprimeiroscript : MonoBehaviour
{
    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //trasnform
      
        transform.Rotate(0, 100 * Time.deltaTime, 0); 
    }
}
