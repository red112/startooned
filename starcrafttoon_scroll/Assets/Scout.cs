using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : MonoBehaviour
{
    public float speed = 10.0f;

    private float minWorldX;
    private float maxWorldX;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 limitPt = new Vector3(0.0f, 0.0f, 0.0f);
        limitPt = Camera.main.ScreenToWorldPoint(limitPt);
        minWorldX = limitPt.x;

        limitPt = new Vector3(Screen.width, 0.0f, 0.0f);
        limitPt = Camera.main.ScreenToWorldPoint(limitPt);
        maxWorldX = limitPt.x;

    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        //float dy = Input.GetAxis("Vertical");

        transform.position += new Vector3(dx, 0, 0) * Time.deltaTime * speed;
        if (transform.position.x < minWorldX)
        {
            transform.position = new Vector3(minWorldX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > maxWorldX)
        {
            transform.position = new Vector3(maxWorldX, transform.position.y, transform.position.z);
        }

        /*
        // 스크린 좌표계에서 비교하는 방법
        // 범위 밖이면...
        Vector3 scrPos = Camera.main.WorldToScreenPoint(transform.position);
        if (scrPos.x < 0 || scrPos.x > Screen.width)
        {
            if (scrPos.x < 0)
            {
                scrPos = new Vector3(0.0f, scrPos.y, scrPos.z);
            }
            else if (scrPos.x > Screen.width)
            {
                scrPos = new Vector3(Screen.width, scrPos.y, scrPos.z);
            }

            //조정 된 범위의 스크린 좌표로 다시 World 좌표 설정
            transform.position = Camera.main.ScreenToWorldPoint(scrPos);
        }
        */
    }
}
