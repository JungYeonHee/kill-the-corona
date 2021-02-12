using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce2 : MonoBehaviour
{
    float time = 3;
    public float _size = 1;

    public float _upSizeTime = 0.3f;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Amin();
    }

    public void Amin()
    {
        if (time <= _upSizeTime)
        {
            transform.localScale = Vector3.one * (1 + _size * time);
        }
        else if (time <= _upSizeTime * 2)
        {
            transform.localScale = Vector3.one * (2 * _size * _upSizeTime + 1 - time * _size);
        }
        else
        {
            transform.localScale = Vector3.one;
            time = 0;
        }
        time += Time.deltaTime;

    }




}
