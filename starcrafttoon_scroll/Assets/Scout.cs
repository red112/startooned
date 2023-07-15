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
        // ��ũ�� ��ǥ�迡�� ���ϴ� ���
        // ���� ���̸�...
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

            //���� �� ������ ��ũ�� ��ǥ�� �ٽ� World ��ǥ ����
            transform.position = Camera.main.ScreenToWorldPoint(scrPos);
        }
        */
    }
}
