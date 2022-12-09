using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResults<T> : DataResults<T>
    {
        public SuccessDataResults(T data, bool success, string message) : base(data, success:true, message)
        {
        }

        public SuccessDataResults(T data) : base(data, success: true)
        {
            
        }
        //public SuccessDataResults(string message):base(default,success:true,message)
        //{

        //}
        //public SuccessDataResults(): base(default,success:true)
        //{

        //}
    }
}
