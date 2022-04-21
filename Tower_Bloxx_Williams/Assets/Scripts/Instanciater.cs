using System.Collections.Generic;
using UnityEngine;

namespace Tower_Bloxx_W 
{
    public class Instanciater : MonoBehaviour
    {       
        [SerializeField] private GameObject instancePrefab;

        [SerializeField] private Transform instancePosition;

        private List<GameObject> blocks = new List<GameObject>();

        private void Start()
        {
            NewInstance();            
        }

        public void NewInstance() 
        {           
            blocks.Add(Instantiate<GameObject>(instancePrefab, instancePosition.position, Quaternion.identity));
        }
    }
}