using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour


{

    public float power = 0.5f;
    public float duration = 0.5f;
    public float slowDownAmount = 1f;
    private bool should_Shake;
    private float inititalDuration;

    private Vector3 startPosition;




    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        inititalDuration = duration;

    }

    // Update is called once per frame
    void Update()
    {
        Shake();

    }
    void Shake()
    {
        if (should_Shake)
        {
            if(duration > 0f)
            {
                transform.localPosition = startPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime + slowDownAmount;
                should_Shake = true;
            }
            else
            {
                should_Shake = false;
                duration = inititalDuration;
                transform.localPosition = startPosition;
            }

        }


    }

    public bool ShouldShake
    {
        get { return should_Shake; }
        set { should_Shake = value; }
    }





}
