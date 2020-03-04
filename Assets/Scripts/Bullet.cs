using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Target;
    float speed;
    void Start()
    {
        speed = 0.1f;
        Target = GetComponentInParent<Shooting>().Target;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null)
            Destroy(gameObject);
        else 
            transform.position = Vector3.MoveTowards(transform.position,Target.transform.position, speed);
        if (Target != null && transform.position == Target.transform.position)
        {
            Target.GetComponent<Enemy>().Hp--;
            Destroy(gameObject);
        }
    }
}
