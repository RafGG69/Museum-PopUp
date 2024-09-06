using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Tweening : MonoBehaviour
{
    public GameObject TweenObject;

    public float time;

    public float finalPost;

    public Vector3 finalpost2;

    public LeanTweenType type;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveY()
    {

        LeanTween.moveY(TweenObject, finalPost, time).setEase(type);

    }

    public void reset()
    {
        LeanTween.moveY(TweenObject, finalPost, time).setEase(type);

    }

    public void Move()
    {
        LeanTween.moveLocalY(TweenObject, finalPost, time).setEase(type);
    }

    public void resetmove()
    {
        LeanTween.moveLocalY(TweenObject, finalPost, time).setEase(type);
    }
}
