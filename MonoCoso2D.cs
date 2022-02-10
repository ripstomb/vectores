using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonoCoso2D : MonoBehaviour

{
    [SerializeField]
    Coso2D vec1, vec2, vec3;
    Coso2D vectorSum, vectorSub, vectorEsc, vectorEsc2;
    public float mul;
    public float mul2;
    [Range(0, 1)]
    public float range = 0.0f;
    void Start()
    {
        vec1 = new Coso2D(2, 1);
        vec2 = new Coso2D(1, 2);
        var suma = vec1 + vec2;
        vectorSum = vec1.Sum(vec2);
        vectorSub = vec1.Sub(vec2);
    }
    private void Update()
    {
        vectorEsc = vec1.Esc(mul);
        vectorEsc2 = vec2.Esc(mul2);
        vec1.Draw();
        vec2.Draw();
        var diffvector = vec2.Sub(vec1);
        diffvector = diffvector.Esc(range);
        diffvector.Draw();
        diffvector.Draw(vec1);
        vectorEsc.Draw();
        vectorEsc2.Draw();
    }
    public void Draw()
    {
        Debug.Log(vectorSum.ToString());
        Debug.Log(vectorSub.ToString());
        Debug.Log(vectorEsc.ToString());
    }
}
