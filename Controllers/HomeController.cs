using HuxueApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HuxueApi.Controllers
{
    [Route("Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="id">编码</param>
        [HttpGet]
        public Home GetHome(string id)
        {
            return (new Home());

        }
        /// <summary>
        /// 添加数据
        /// </summary>
        [HttpPost]
        public Home AddHomeInfo(Home home)
        {
            return (new Home());

        }
        /// <summary>
        /// 更新数据
        /// </summary>
        [HttpPut]
        public Home UpdateHomeInfo(Home home)
        {
            return (new Home());

        }
       /// <summary>
       /// 删除数据
       /// </summary>
       /// <param name="id">编码</param>
       /// <returns></returns>
        [HttpDelete]
        public Home DeleteHomeInfo(string id)
        {
            return (new Home());
        }
    }
}
