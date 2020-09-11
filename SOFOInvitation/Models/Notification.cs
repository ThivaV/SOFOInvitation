using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOFOInvitation.Models
{
    public class Notification
    {
        [JsonProperty(PropertyName = "@odata.context")]
        public string ODataContext { get; set; }
        public List<Value> Value { get; set; }
    }

    public class Value
    {
        [JsonProperty(PropertyName = "@odata.type")]
        public string ODataType { get; set; }
        public string Id { get; set; }
        public string SubscriptionId { get; set; }
        public DateTime SubscriptionExpirationDateTime { get; set; }
        public int SequenceNumber { get; set; }
        public string ChangeType { get; set; }
        public string Resource { get; set; }
        public ResourceData ResourceData { get; set; }
    }

    public class ResourceData
    {
        [JsonProperty(PropertyName = "@odata.type")]
        public string ODataType { get; set; }

        [JsonProperty(PropertyName = "@odata.id")]
        public string ODataId { get; set; }

        [JsonProperty(PropertyName = "@odata.etag")]
        public string ODataEtag { get; set; }
        public string Id { get; set; }
    }
}
