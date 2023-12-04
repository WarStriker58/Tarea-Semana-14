using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour
{
    private Animator _compAnimator;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroidObject()
    {
        Destroy(this.gameObject);
    }
}
