using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _targetPosition = new(2, 2, 2f);
    
    private void Start()
    {
        _wallPrefab.position = _targetPosition;
        Instantiate(_wallPrefab);
    }
}
