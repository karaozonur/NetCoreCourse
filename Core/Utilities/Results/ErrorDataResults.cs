using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResults<T> : DataResults<T>
    {
        public ErrorDataResults(T data,  string message) : base(data, success:false, message)
        {
        }
        public ErrorDataResults(T data) : base(data, success: false)
        {

        }

        //public ErrorDataResults(string message):base(default,success:false,message)
        //{

        //}
        //public ErrorDataResults(): base(default,success:false)
        //{

        //}
    }
}
