using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header ("Inscribed")]
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the appletree moves
    public float speed = 1f;

    //distance where appletree turn around
    public float leftAndRightEdge = 10f;

    //Chance that the apple tree will change directions
    public float ChangeDirChance = 0.1f;

    //Seconds between Apple instatiations
    public float appleDropChance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        //Chancing Directions
    }
}
