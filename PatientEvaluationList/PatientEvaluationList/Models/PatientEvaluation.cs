using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientEvaluationList
{
    public class PatientEvaluation
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string PName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string PSex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime  Birthday{ get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public string  Profession{ get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string  FIDCard{ get; set; }
        /// <summary>
        /// 国籍
        /// </summary>
        public string  Citizenship{ get; set; }
        /// <summary>
        /// 户籍地址
        /// </summary>
        public string  HJAddress{ get; set; }
        /// <summary>
        /// 现住址
        /// </summary>
        public string  FAddress{ get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string  Mailbox{ get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string  FTel{ get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string  FPhone{ get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string FMarriage { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string  FContacts{ get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string  FContactsTel{ get; set; }
        /// <summary>
        /// 联系人与就诊人关系
        /// </summary>
        public string  Relation{ get; set; }
        /// <summary>
        /// 宗教
        /// </summary>
        public string  Faith{ get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        public string  Language{ get; set; }
        /// <summary>
        /// 教育程度
        /// </summary>
        public string  Education{ get; set; }
        /// <summary>
        /// 医疗保险
        /// </summary>
        public string  Medicare{ get; set; }
        /// <summary>
        /// 血型
        /// </summary>
        public string  BloodType{ get; set; }
        /// <summary>
        /// 输血型
        /// </summary>
        public string  Transfusion{ get; set; }
        /// <summary>
        /// 药物过敏
        /// </summary>
        public string  DrugAllergy{ get; set; }
        /// <summary>
        /// 食物过敏
        /// </summary>
        public string  FoodAllergy{ get; set; }
        /// <summary>
        /// 吸烟
        /// </summary>
        public string  Smoke{ get; set; }
        /// <summary>
        /// 饮酒
        /// </summary>
        public string  Drink{ get; set; }
        /// <summary>
        /// 其他保险
        /// </summary>
        public string  RestsBX{ get; set; }
        /// <summary>
        /// 其他过敏食物
        /// </summary>
        public string  RestsGMSW{ get; set; }
        /// <summary>
        /// 其他过敏药物
        /// </summary>
        public string  RestsGMYW{ get; set; }
        /// <summary>
        /// 具体吸烟数量
        /// </summary>
        public string RestsSmoke { get; set; }

    }
}
