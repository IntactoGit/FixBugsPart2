using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;

    [SerializeField] 
    private GameObject _gameObject;
   
    private void Start()
    { 
        Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
       
        Destroy(FindObjectOfType<GameObject>());
    }

    
}
