using System;
using System.Collections;
using UnityEngine;

public class SequentialObjectActivator : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public float delayBetweenObjects = 5f;

    private void Start()
    {
        StartCoroutine(ActivateObjectsSequentially());
    }

    private IEnumerator ActivateObjectsSequentially()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(delayBetweenObjects);
        }
    }

    internal void ActivateNextObject()
    {
        throw new NotImplementedException();
    }
}
