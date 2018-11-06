using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MVCMemberships.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? Id { get; set; }
        public int? ItemId { get; set; }
        public int? ProductId { get; set; }
        public int? SubscriptionId { get; set; }
        public string ActionParameters {
            get
            {
                StringBuilder sb = new StringBuilder("?");
                if (Id > 0 && Id != null) 
                    sb.Append(string.Format($"Id={Id}&"));
                if (ItemId > 0 && ItemId != null)
                    sb.Append(string.Format($"ItemId={ItemId}&"));
                if (ProductId > 0 && ProductId != null)
                    sb.Append(string.Format($"ProductId={ProductId}&"));
                if (SubscriptionId > 0 && SubscriptionId != null)
                    sb.Append(string.Format($"SubscriptionId={SubscriptionId}"));
                return sb.ToString();
            }
        }
    }
}