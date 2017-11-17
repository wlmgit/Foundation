using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Foundation.ResourceLoad
{
    public class RequestInfo 
    {
        //资源反馈信息
        public ResourceRequest mRequest;

        public bool isKeepInMemory;

        public List<IResLoad> mListeners;

        public void AddListener(IResLoad listener)
        {
            if (mListeners == null)
                mListeners = new List<IResLoad>();
            if (!mListeners.Contains(listener))
                mListeners.Add(listener);
        }

        public string mAssetName;

        public string AssetFullName
        {
            get
            {
                return ResourceManage.Instance.GetFileFullName(mAssetName);
            }
        }

        public Type m_assetType;

        /// <summary>
        /// 资源是否加载完成
        /// </summary>
        public bool IsDone
        {
            get
            {
                return mRequest != null && mRequest.isDone;
            }
        }
        /// <summary>
        /// 加载到的资源
        /// </summary>
        public object Asset
        {
            get
            {
                return mRequest != null ? mRequest.asset : null;
            }
        }

        public void LoadAsync()
        {
            mRequest = Resources.LoadAsync(AssetFullName,m_assetType);
        }
    }
}


