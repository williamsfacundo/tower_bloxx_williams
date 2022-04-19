using System.Collections.Generic;
using UnityEngine;

namespace Tower_Bloxx_W 
{
    public class Instanciater : MonoBehaviour
    {
        [SerializeField] private static short currentInstances = 0;
        [SerializeField] private static short maxInstances = 5;
        
        [SerializeField] private GameObject objectForCollisionDetection;
        [SerializeField] private GameObject instancePrefab;

        [SerializeField] private Transform instancePosition;
        
        private bool instantiateObjectRestriction;
        
        private void Start()
        {
            instantiateObjectRestriction = false;
        }               

        private void OnCollisionEnter(Collision collision)
        {           
            if (collision.gameObject.name == objectForCollisionDetection.name && !instantiateObjectRestriction) 
            {
                Instantiate<GameObject>(instancePrefab, instancePosition.position, Quaternion.identity);

                instantiateObjectRestriction = true;

                currentInstances += 1;
            }                                                   
        }        
    }
}