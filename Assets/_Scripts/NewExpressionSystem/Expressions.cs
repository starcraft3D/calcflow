﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expressions : MonoBehaviour
{
    List<Transform> expressions;
    public enum ExpressionType { Constant, Paramet, VecField }
    public enum Action { Add, Remove, Hide, Flowline }

    //NOTES: managing expressions
    // - need to keep track of selected Expr
    // - selected Expr affects which Actions are shown, the graph and output destination

    void Awake()
    {
        expressions = new List<Transform>();
    }

    public void addExpr(Transform exp)
    {
        expressions.Add(exp);
        exp.SetParent(transform);
    }

    void Update()
    {

    }
}