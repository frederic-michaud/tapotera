using UnityEngine;

public class RemoveLetterFromActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
            Debug.Log("trigger collision with invisible");
            letterSpawnerLetter obj = GameObject.FindWithTag("LetterSpawner").GetComponent<letterSpawnerLetter>();
            
            if (obj != null) { 
                Debug.Log("Object Instance: " + collision.gameObject.GetInstanceID());              
                obj.removeLetter(collision.gameObject.GetInstanceID());
        }
    }
}
