using UnityEngine;

public class GameScaler : MonoBehaviour
{
    public Collider2D ScalerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            BoxCollider2D corgiColl = GetComponent<BoxCollider2D>();
            float temp = GetPercentageDifference(corgiColl.bounds.size.x, ScalerCollider.bounds.size.x);
            Debug.LogError(temp);
            var transform1 = transform;
            transform1.localScale = new Vector3(
                transform1.localScale.x + temp,
                transform1.localScale.y + temp,
                transform1.localScale.z + temp);
        }
    }

    float GetPercentageDifference(float valueA, float valueB)
    {
        if (valueA < valueB)
        {
            return 1 - valueA / valueB;
        }

        return -(1 - valueB / valueA);
    }
}
