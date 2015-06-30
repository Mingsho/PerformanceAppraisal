using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerformanceAppraisal.Utilities
{
    public class ImageUtil
    {

        public byte[] ReadFile(HttpPostedFile file)
        {
            byte[] data = new Byte[file.ContentLength];

            file.InputStream.Read(data, 0, file.ContentLength);

            return data;

        }
    }
}