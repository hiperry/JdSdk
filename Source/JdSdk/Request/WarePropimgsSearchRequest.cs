#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:41.29393 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据商品Id，检索商品主图 Request
    /// </summary>
    public class WarePropimgsSearchRequest : IJdRequest<WarePropimgsSearchResponse>
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <example>1</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Int64 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        /// <example>20</example>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 可选字段
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.propimgs.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}