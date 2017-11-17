using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Foundation.ResourceLoad
{
    public class AssetInfo 
    {
        public object mAsset;

        //是否常驻内存
        public bool isKeepInMemory;

        //引用数量
        public int refCount = 0;
    }
}

