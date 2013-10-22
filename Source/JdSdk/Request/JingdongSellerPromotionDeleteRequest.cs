#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:55.85776 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 删除促销，只能删除未审核、已驳回、已生效、已暂停等状态的促销 Request
    /// </summary>
    public class JingdongSellerPromotionDeleteRequest : JdRequestBase<JingdongSellerPromotionDeleteResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>123456</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
        }

    }
}
