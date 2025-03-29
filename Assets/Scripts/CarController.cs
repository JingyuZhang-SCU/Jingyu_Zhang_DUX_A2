using UnityEngine;

public class CarController : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Vector3 initialScale;
    private Vector3 initialColliderSize;

    public float rotationSpeed = 90f;
    public float moveSpeed = 5f;
    public float scaleSpeed = 0.1f;
    public float moveRange = 15f;

    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        initialScale = transform.localScale;
    }

    public void Rotate(float direction)
    {
        transform.Rotate(Vector3.up * direction * rotationSpeed * Time.deltaTime);
    }

    public void Move(float direction)
    {
        Vector3 newPosition = transform.position;
        newPosition.x += direction * moveSpeed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -moveRange, moveRange);
        transform.position = newPosition;
    }

    public void Scale(float direction)
    {
        Vector3 newScale = transform.localScale;
        newScale += Vector3.one * direction * scaleSpeed * Time.deltaTime;
        newScale = Vector3.Max(newScale, Vector3.one * 0.05f);
        newScale = Vector3.Min(newScale, Vector3.one * 1f);
        transform.localScale = newScale;

        float currentScale = newScale.y;
        float newY = 6.8f * currentScale - 0.04f;
        transform.position = new Vector3(
            transform.position.x,
            newY,
            transform.position.z
        );


    }

    public void ResetToInitial()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        transform.localScale = initialScale;
    }
}