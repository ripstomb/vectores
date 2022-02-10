using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct Coso2D
{
    public float x;
    public float y;
    public Coso2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public Coso2D Sum(Coso2D other)
    {
        var result = new Coso2D();
        result.x = this.x + other.x;
        result.y = this.y + other.y;
        return result;
    }
    public Coso2D Sub(Coso2D other)
    {
        var result = new Coso2D();
        result.x = this.x - other.x;
        result.y = this.y - other.y;
        return result;
    }
    public Coso2D Esc(float esc)
    {
        var result = new Coso2D();
        result.x = this.x * esc;
        result.y = this.y * esc;
        return result;
    }
    public static Coso2D operator +(Coso2D a, Coso2D b)
    {
        return new Coso2D(a.x + b.x, a.y + b.y);
    }
    public static Coso2D operator -(Coso2D a, Coso2D b)
    {
        return new Coso2D(a.x - b.x, a.y - b.y);
    }
    public static Coso2D operator *(Coso2D a, float esc)
    {
        return new Coso2D(a.x * esc, a.y * esc);
    }
    public void Draw()
    {
        Debug.DrawLine(Vector2.zero, new Vector2(x, y), Color.black);
    }
    public void Draw(Coso2D origen)
    {
        Debug.DrawLine(new Vector2(origen.x, origen.y), new Vector2(x + origen.x, y
       + origen.y), Color.black);
    }
}
