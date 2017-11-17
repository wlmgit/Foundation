using System.Collections;
using UnityEngine;

namespace Foundation.ResourceLoad
{
    //资源加载回调
    public interface IResLoad
    {
        void Finish(object asset);

        void Failure();
    }
}

