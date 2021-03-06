#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:12.98698 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 新增一个商品 Response
    /// </summary>
    public class WareAddResponse : JdResponse
    {
        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的id
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU集合
        /// </summary>
        [XmlElement("skus")]
        [JsonProperty("skus")]
        public List<SkuInfo> Skus
        {
            get;
            set;
        }

    }
}
