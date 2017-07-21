using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NLog;
using PatientEvaluationList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientEvaluationList.Controllers
{
    public class EvaluationController : Controller
    {
        DataModel _db;
        /// <summary>
        /// 日志对象
        /// </summary>
        Logger _log;
        /// <summary>
        /// 配置文件
        /// </summary>
        /// <summary>
        /// 构函初始化
        /// </summary>
        /// <param name="connections"></param>
        /// <param name="appseting"></param>
        public EvaluationController(IOptions<ConnectionSetting> connections)
        {
            _log = LogManager.GetCurrentClassLogger();
            _db = new DataModel(connections.Value.hisConnectionStrings);
        }
        [HttpGet("EvaluationIndex")]
        public IActionResult EvaluationIndex()
        {
            return View();
        }
        /// <summary>
        /// 添加页面
        /// </summary>
        /// <returns></returns>
        [HttpGet("showaddevaluation")]
        public IActionResult ShowAddEvaluation()
        {
            return View();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="peln"></param>
        /// <returns></returns>
        [HttpPost("addpeln")]
        public IActionResult AddEvaluationTable(PatientEvaluation peln)
        {
            try
            {
                peln.ID = Guid.NewGuid();
                var list = _db.AddEvaluationTable(peln);
                _log.Info($"添加成功:{peln.ID }");
                return new JsonResult(new { result = 1, message = "添加成功！", id= peln.ID });
            }
            catch (Exception exc)
            {

                _log.Fatal($"【添加失败异常】：{exc.Message}");
                return new JsonResult(new { result = 0, messge = exc.Message });
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="peln"></param>
        /// <returns></returns>
        [HttpPost("modifyeval")]
        public IActionResult ModifyEvaluationbyID(PatientEvaluation peln)
        {
            try
            {
                var list = _db.ModifyEvaluationbyID(peln);
                return new JsonResult(new { result = 1, message = "修改成功" });
            }
            catch (Exception exc)
            {

                _log.Fatal($"【添加失败异常】：{exc.Message}");
                return new JsonResult(new { result = 0, messge = exc.Message });
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getevaluationbyid")]
        public IActionResult GetEvaluationbyID(Guid id)
        {
            try
            {
                var list = _db.GetEvaluationbyID(id);
                return new JsonResult(new { result = 1, message = "查询成功", data = list }, new JsonSerializerSettings()
                {
                    DateFormatString = "yyyy-MM-dd"
                });
            }
            catch (Exception exc)
            {

                _log.Fatal($"【查询异常】：{exc.Message}");
                return new JsonResult(new { result = 0, messge = exc.Message });
            }
        }
        /// <summary>
        /// 全部就诊单页面
        /// </summary>
        /// <returns></returns>
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getallevaluation")]
        public IActionResult GetAllEvaluation()
        {
            try
            {
                var list = _db.GetAllEvaluation();
                return new JsonResult(new { result = 1, message = "查询成功", data = list }, new JsonSerializerSettings()
                {
                    DateFormatString = "yyyy-MM-dd"
                });
            }
            catch (Exception exc)
            {

                _log.Fatal($"【查询异常】：{exc.Message}");
                return new JsonResult(new { result = 0, messge = exc.Message });
            }
        }
    }
}
