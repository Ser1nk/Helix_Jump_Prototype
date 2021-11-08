using UnityEngine;

public class SplashController : MonoBehaviour
{
    [SerializeField] private GameObject _splash;

    private const string Ground = "Ground"; 

    private void SpawnSplash()
    {
        Instantiate(_splash);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Ground))
        {
            SpawnSplash();
            
        }

    }

}
