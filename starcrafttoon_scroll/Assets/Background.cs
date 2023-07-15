using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    Material mat;
    float curOffset = 0.0f;
    float speed = 0.08f;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        curOffset += speed * Time.deltaTime;
        mat.mainTextureOffset = new Vector2(0, curOffset);
    }
}
