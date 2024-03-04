using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions;

public class AppException: Exception
{
    public AppException()
    {
    }

    protected AppException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public HttpStatusCode HttpStatusCode { get; set; }
    public ApiResultStatusCode ApiStatusCode { get; set; }
    public object AdditionalData { get; set; }


}
