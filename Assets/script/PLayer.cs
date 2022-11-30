using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour

{
    // Start is called before the first frame update
    public bool move = true;
    bool pos = false;
    bool po;
    [SerializeField]
    float speed;
    [SerializeField]
    float limit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (move)
        {

            Move();
        }
      if (pos)
        {
            transform.position += Vector3.right * 1 * 10 * Time.deltaTime;
            float xppos = Mathf.Clamp(transform.position.x, -8, 8);
            transform.position = new Vector3(xppos, -2, 0);
        }
        if (po)
        {
            transform.position += Vector3.right * -1 * 10 * Time.deltaTime;
            float xppos = Mathf.Clamp(transform.position.x, -8, 8);
            transform.position = new Vector3(xppos, -2, 0);
        }
    }
    private void Move()
    {
        float a = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * a * speed*Time.deltaTime;
        float xppos = Mathf.Clamp(transform.position.x, -limit, limit);
        transform.position = new Vector3(xppos, -2, 0);
    }
    public void rdown()
    {
        pos = true;
        
    }
    public void rup()
    {
        pos = false;

    }
    public void ldown()
    {
        po = true;
    }
    public void lup()
    {
        po = false;
    }
}
