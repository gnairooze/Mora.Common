using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mora.Common.Method.Parameter
{
    public class Result<T>
    {
        #region properties
        public long ID { get; set; }
        public Guid BusinessID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public T Data { get; set; }
        #endregion
    }
}
