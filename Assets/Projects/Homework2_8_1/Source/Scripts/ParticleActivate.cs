using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            ActivateParticleOnPosition(position);
        }
    }

    private void ActivateParticleOnPosition(Vector3 position)
    {
        _particle.gameObject.SetActive(false);
        _particle.transform.position = position;
        _particle.gameObject.SetActive(true);
    }
}
