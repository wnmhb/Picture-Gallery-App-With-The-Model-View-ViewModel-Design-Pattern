using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class PictureData
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        [DataMember]
        public string ImageSource { get; set; }

        /// <summary>
        /// 图片说明
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}
