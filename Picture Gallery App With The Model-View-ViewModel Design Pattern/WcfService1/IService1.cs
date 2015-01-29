using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<PictureData> GetAllPictureData();

        /// <summary>
        /// Get the data of pageIndex
        /// </summary>
        /// <param name="pageIndex">which page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        [OperationContract]
        List<PictureData> GetPageData(int pageIndex, int pageSize);

        /// <summary>
        /// Get all data size
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        int GetPictureDataCount();

        /// <summary>
        /// Get the page number
        /// </summary>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [OperationContract]
        int GetPageCount(int pageSize);
    }
}
