using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace WcfService1
{
    public class Service1 : IService1
    {        
        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        public List<PictureData> GetAllPictureData() {
            List<PictureData> result = new List<PictureData>();
            foreach (string str in Directory.GetFiles(@"C:\Users\wnmhb\Pictures\picture"))
            {
                if (str.ToLower().EndsWith(".jpg") || str.ToLower().EndsWith(".png"))
                    result.Add(new PictureData() { ImageSource = str, Name = Path.GetFileNameWithoutExtension(str) });
            }
            return result;
        }

        /// <summary>
        /// Get the data of pageIndex
        /// </summary>
        /// <param name="pageIndex">which page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        public List<PictureData> GetPageData(int pageIndex, int pageSize)
        {
            return GetAllPictureData().Take(pageSize * (pageIndex + 1)).Skip(pageSize * pageIndex).ToList();
        }

        /// <summary>
        /// Get all data size
        /// </summary>
        /// <returns></returns>
        public int GetPictureDataCount() {
            return GetAllPictureData().Count;
        }

        /// <summary>
        /// Get the page number
        /// </summary>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public int GetPageCount(int pageSize)
        {
            int pageCount;
            List<PictureData> PictureDataList = GetAllPictureData();
            if (PictureDataList.Count % pageSize == 0)
            {
                pageCount = PictureDataList.Count / pageSize;
            }
            else
            {
                pageCount = PictureDataList.Count / pageSize + 1;
            }
            return pageCount;
        }
    }
}
