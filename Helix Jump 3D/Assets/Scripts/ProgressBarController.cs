using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _finishTransform;

    private Vector3 _finishPosition;

    private float _fullDistance;

    private void Start()
    {
        _finishPosition = _finishTransform.position;
        _fullDistance = GetDistance();
    }

    private void Update()
    {
        float newDistance = GetDistance();
        float progressValue = Mathf.InverseLerp(_fullDistance, 0f, newDistance);

        UpdateProgressFill(progressValue);
    }

    private float GetDistance()
    {
        return Vector3.Distance(_playerTransform.position, _finishTransform.position);
    }

    private void UpdateProgressFill(float value)
    {
        _slider.value = value;
    }


}
