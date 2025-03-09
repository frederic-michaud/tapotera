using UnityEngine;
using System.Collections.Generic;


public class letterSpawnerLetter : MonoBehaviour
{

    public GameObject F;
    public GameObject D;
    public GameObject J;
    public GameObject C;
    public LogicManager logic;
    private List<GameObject> ActiveLetters = new List<GameObject>();
    private List<GameObject> InactiveLetters = new List<GameObject>();
    public float SpawnRate;
    private GameObject[] letters; 
    private float timer;
    public float jumpForce;
    public void removeLetter(int letterID) {
        Debug.Log("Removing letter with ID :" + letterID);
        ActiveLetters.RemoveAll(obj => obj.GetInstanceID() == letterID);
        
        //InactiveLetters.Add(obj);
        
    }
    void Start()
    {
        letters = new GameObject[] { F, D, J};
        //letters = new GameObject[] { F, D };
    }
    
    public void Stop() {
        ActiveLetters.Clear();
        SpawnRate = 10000000;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate) {
            timer += Time.deltaTime;
        } else {
            GameObject randomLetter = letters[Random.Range(0, letters.Length)];
            GameObject obj = Instantiate(randomLetter, transform.position, transform.rotation);
            ActiveLetters.Add(obj);
            timer = 0;    
        }
        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))) {
            if (Input.GetKeyDown(key) && key >= KeyCode.A && key <= KeyCode.Z) 
                    if (ActiveLetters.Count > 0) {
                        GameObject obj = ActiveLetters[0];
                        if (obj.tag == key.ToString()) {
                            logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
                            logic.AddScore();
                            ActiveLetters.RemoveAt(0);
                            Destroy(obj.gameObject);
                        } else {
                            Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                            Debug.Log("wrong letter");
                            if (rb != null) {
                                // Set the y velocity to make it jump (only change the Y-axis)
                                Debug.Log("Update speed to " + jumpForce);
                                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                            }
                        }
                    }
                }            
        }
}  

