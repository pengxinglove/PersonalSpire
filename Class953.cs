﻿using System;
using System.Collections;
using System.IO;

internal class Class953 : Interface47
{
    private readonly ArrayList arrayList_0 = new ArrayList();

    private Class226 imethod_0(int A_0)
    {
        if (this.arrayList_0.Count == 0)
        {
            return null;
        }
        return (Class226) this.arrayList_0[((A_0 > this.arrayList_0.Count) ? this.arrayList_0.Count : A_0) - 1];
    }

    private int imethod_1(Class226 A_0)
    {
        this.arrayList_0.Add(A_0);
        return this.arrayList_0.Count;
    }

    internal void method_0(BinaryWriter A_0, int A_1)
    {
        foreach (Class226 class2 in this.arrayList_0)
        {
            class2.uint_0 = (uint) A_1;
            class2.method_2(A_0);
        }
    }
}

