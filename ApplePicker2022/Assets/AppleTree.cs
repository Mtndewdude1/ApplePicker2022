using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the appletree moves
    public float speed = 1f;

    //distance where appletree turn around
    public float leftAndRightEdge = 10f;

    //Chance that the apple tree will change directions
    public float ChangeDirChance = 0.1f;

    //Seconds between Apple instatiations
    public float appleDropDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //start dropping apples
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Chancing Directions
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);

        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);//move left
        }
        Debug.Log(pos.x);
        Debug.Log(speed);
    }

    private void FixedUpdate()
    {
        //max 50fps
        if (Random.value < ChangeDirChance)
        {
            speed *= -1;
        }
    }

}
