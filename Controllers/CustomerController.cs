using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Creating_With_Stored_Procedure.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Web.Script.Services;

namespace API_Creating_With_Stored_Procedure.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerDataModelContainer db = new CustomerDataModelContainer();
        
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [HttpGet]
        public string getCustomerList()
        {
            List<sp_user_list_Result> list = new List<sp_user_list_Result>();
            list = db.sp_user_list().ToList();
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(list).ToString();
            //var json= js.Serialize(list);
            //var response = json.Replace(@"\", string.Empty);
            //return response.ToString();
        }
    }
}
