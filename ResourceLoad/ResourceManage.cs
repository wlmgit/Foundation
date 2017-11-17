using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Foundation.Common;
using System.IO;

namespace Foundation.ResourceLoad
{
    public class ResourceManage : UnitySingleton<ResourceManage>
    {

        private Dictionary<string, string> m_assetPathDic = new Dictionary<string, string>();

        //所有资源字典
        private Dictionary<string, AssetInfo> m_assetDic = new Dictionary<string, AssetInfo>();

        public string GetFileFullName(string assetName)
        {
            if (m_assetPathDic.Count == 0)
            {
                TextAsset tex = Resources.Load<TextAsset>("res");
                StringReader strReader = new StringReader(tex.text);
                string fileName = strReader.ReadLine();
                while (fileName != null)
                {
                    string[] ss = fileName.Split('=');
                    m_assetPathDic.Add(ss[0],ss[1]);
                    fileName = strReader.ReadLine();
                }
            }
            return assetName = m_assetPathDic[assetName] + "/" + assetName;
        }
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

