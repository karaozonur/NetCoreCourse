using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResults : Result
    {
        public SuccessResults(bool success, string message) : base(success, message)
        {
        }
        public SuccessResults() : base(success:true)
        {
            
        }
    }
}
