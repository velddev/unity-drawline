﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class UILine : MaskableGraphic, IMeshModifier {
    // Use this for initialization
    public List<Vector3> points = new List<Vector3>();
    
    public void ModifyMesh(VertexHelper vh)
    {
        EditMesh(vh);
    }
    public void ModifyMesh(Mesh mesh)
    {
        using(var vh = new VertexHelper(mesh))
        {
            EditMesh(vh);
            vh.FillMesh(mesh);
        }
    }

    void EditMesh(VertexHelper vh)
    {
     
               
    }
    
}
