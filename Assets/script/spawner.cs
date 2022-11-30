using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{   [SerializeField]
    int pos;
    [SerializeField]
    float time;
    public GameObject[] hi;

    public static spawner instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Starting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spaaw()
    {
        int cand = Random.Range(0, hi.Length);
        int ran = Random.Range(-pos, pos);
        Vector3 position = new Vector3(ran, 5, 0);
        Instantiate(hi[cand],position, transform.rotation);
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            Spaaw();
            yield return new WaitForSeconds(time);
        }
    }
    public void Starting()
    {
        StartCoroutine("Spawn");
    }
    public void Stoping()
    {
        StopCoroutine("Spawn");
    }
}
