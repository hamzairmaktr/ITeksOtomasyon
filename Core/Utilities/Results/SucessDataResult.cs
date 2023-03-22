using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SucessDataResult<T>:DataResult<T>
    {
        public SucessDataResult(T data, string message) : base(data,true, message)
        {
        }

        public SucessDataResult(T data) : base(data,true)
        {

        }
        public SucessDataResult(string message):base(default,true,message)
        {

        }
        public SucessDataResult():base(default,true)
        {

        }
    }
}
