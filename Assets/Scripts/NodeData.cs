using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeData
{
    public float[] _fParameters { get; set; }
    public Vector3 _vPosition { get; set; }
    public string _sDescription { get; set; }

    public NodeData(float[] fParameters, Vector3 vPosition, string sDescription)
    {
        this._fParameters = fParameters;
        this._vPosition = vPosition;
        this._sDescription = sDescription;
    }

}
