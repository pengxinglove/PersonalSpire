﻿using System;
using System.Collections;

internal class Class720 : IComparer
{
    int IComparer.Compare(object A_0, object A_1)
    {
        Class714 class2 = A_0 as Class714;
        Class714 class3 = A_1 as Class714;
        return class2.method_35().CompareTo(class3.method_35());
    }
}

