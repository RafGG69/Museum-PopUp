using UnityEngine;
using UnityEngine.AddressableAssets;

public class TestAddressable : MonoBehaviour
{
    [SerializeField] AssetReferenceGameObject dinoBiru;

    private void Update()
    {
        if (dinoBiru != null)
        {
            Debug.Log("Ada");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dinoBiru.LoadAssetAsync()
                    .Completed += TestAddressable_Completed;
            }
        }
        else
        {
            Debug.Log("ga ada");
        }
    }

    private void TestAddressable_Completed(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> handle)
    {
        if (handle.Status == UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus.Succeeded)
        {
            Instantiate(handle.Result);
        }
        else
        {
            Debug.Log("Gagal");
        }
    }
}
