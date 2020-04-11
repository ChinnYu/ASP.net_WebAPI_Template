using System.Collections.Generic;
using System.Web.Http;

namespace t3_WebAPI.Controllers
{
    public class UserInfoController : ApiController
    {
        // GET api/userinfo
        //使用Method=Get的方式請求url=api/userinfo,則這個方法會被調用
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET api/userinfo/5
        //查詢單條訊息
        public string Get(int id)
        {
            return "value";
        }

        // POST api/userinfo
        //增加
        public void post([FromBody] string value)
        {
            
        }
        
        // PUT api/userinfo/5
        //修改
        // [HttpPut]
        public void put(int id, [FromBody] string value)
        {
            
        }
        
        // PUT api/userinfo/5
        //刪除
        public void Delete(int id)
        {
            
        }

    }
}