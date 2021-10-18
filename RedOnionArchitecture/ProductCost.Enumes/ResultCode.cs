using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCost.Enumes
{
	public enum ResultCode
	{
		Active = 200,
		InvalidServiceRequest = 400,
		InvalidParameter = 401,
		DataNotFound = 404,
		InternalServerError = 500,
		ServiceUnavailable = 503
	}
}
