using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector2 axis = new Vector2(0, 1);

    private void Start()
    {
        if (target != null) return;
        target = gameObject.transform;
        Debug.Log("Objeto alvo nÃ£o definido." +
                  "Utilizando o prÃ³prio objeto como padrÃ£o.");
    }

    private void Update()
    {
        transform.RotateAround(target.position, 
            axis, speed * Time.deltaTime);
    }

}
