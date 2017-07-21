using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PatientEvaluationList.Models
{
    public class DataModel
    {
        DBHelper _db;
        public DataModel(string connnection)
        {
            _db = new DBHelper(connnection);
        }

        #region 添加就诊单
        /// <summary>
        /// 添加就诊单到数据库
        /// </summary>
        /// <param name="patientevaluation"></param>
        /// <returns></returns>
        public bool AddEvaluationTable(PatientEvaluation pevaton)
        {
            var sql = @"INSERT  INTO T_PE_PatientEvaluations
        ( [ID],
          [PName] ,
          [PSex] ,
          [Birthday] ,
          [Age] ,
          [Profession] ,
          [FIDCard] ,
          [Citizenship] ,
          [HJAddress] ,
          [FAddress] ,
          [Mailbox] ,
          [FTel] ,
          [FPhone] ,
          [FMarriage] ,
          [FContacts] ,
          [FContactsTel] ,
          [Relation] ,
          [Faith] ,
          [Language] ,
          [Education] ,
          [Medicare] ,
          [BloodType] ,
          [Transfusion] ,
          [DrugAllergy] ,
          [FoodAllergy] ,
          [Smoke] ,
          [Drink] ,
          [RestsBX] ,
          [RestsGMSW] ,
          [RestsGMYW] ,
          [RestsSmoke]
        )
VALUES  ( @ID,
          @PName ,
          @PSex ,
          @Birthday ,
          @Age ,
          @Profession ,
          @FIDCard ,
          @Citizenship ,
          @HJAddress ,
          @FAddress ,
          @Mailbox ,
          @FTel ,
          @FPhone ,
          @FMarriage ,
          @FContacts ,
          @FContactsTel ,
          @Relation ,
          @Faith ,
          @Language ,
          @Education ,
          @Medicare ,
          @BloodType ,
          @Transfusion ,
          @DrugAllergy ,
          @FoodAllergy ,
          @Smoke ,
          @Drink ,
          @RestsBX ,
          @RestsGMSW ,
          @RestsGMYW ,
          @RestsSmoke
        )";
            var pars = new List<SqlParameter>();
            pars.Add(new SqlParameter() { ParameterName = "@ID", SqlDbType = System.Data.SqlDbType.UniqueIdentifier, Value = pevaton.ID });
            pars.Add(new SqlParameter() { ParameterName = "@PName", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.PName) });
            pars.Add(new SqlParameter() { ParameterName = "@PSex", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.PSex) });
            pars.Add(new SqlParameter() { ParameterName = "@Birthday", SqlDbType = System.Data.SqlDbType.DateTime, Value = pevaton.Birthday });
            pars.Add(new SqlParameter() { ParameterName = "@Age", SqlDbType = System.Data.SqlDbType.Int, Value = pevaton.Age });
            pars.Add(new SqlParameter() { ParameterName = "@Profession", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Profession) });
            pars.Add(new SqlParameter() { ParameterName = "@FIDCard", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FIDCard) });
            pars.Add(new SqlParameter() { ParameterName = "@Citizenship", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Citizenship) });
            pars.Add(new SqlParameter() { ParameterName = "@HJAddress", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.HJAddress) });
            pars.Add(new SqlParameter() { ParameterName = "@FAddress", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FAddress) });
            pars.Add(new SqlParameter() { ParameterName = "@Mailbox", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Mailbox) });
            pars.Add(new SqlParameter() { ParameterName = "@FTel", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FTel) });
            pars.Add(new SqlParameter() { ParameterName = "@FPhone", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FPhone) });
            pars.Add(new SqlParameter() { ParameterName = "@FMarriage", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FMarriage) });
            pars.Add(new SqlParameter() { ParameterName = "@FContacts", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FContacts) });
            pars.Add(new SqlParameter() { ParameterName = "@FContactsTel", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FContactsTel) });
            pars.Add(new SqlParameter() { ParameterName = "@Relation", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Relation) });
            pars.Add(new SqlParameter() { ParameterName = "@Faith", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Faith) });
            pars.Add(new SqlParameter() { ParameterName = "@Language", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Language) });
            pars.Add(new SqlParameter() { ParameterName = "@Education", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Education) });
            pars.Add(new SqlParameter() { ParameterName = "@Medicare", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Medicare) });
            pars.Add(new SqlParameter() { ParameterName = "@BloodType", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.BloodType) });
            pars.Add(new SqlParameter() { ParameterName = "@Transfusion", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Transfusion) });
            pars.Add(new SqlParameter() { ParameterName = "@DrugAllergy", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.DrugAllergy) });
            pars.Add(new SqlParameter() { ParameterName = "@FoodAllergy", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FoodAllergy) });
            pars.Add(new SqlParameter() { ParameterName = "@Smoke", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Smoke) });
            pars.Add(new SqlParameter() { ParameterName = "@Drink", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Drink) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsBX", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsBX) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsGMSW", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsGMSW) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsGMYW", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsGMYW) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsSmoke", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsSmoke) });

            return _db.SavaData(sql, pars.ToArray()) > 0 ? true : false;
        }

        static string CheckNull(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            else
            {
                return str;
            }
        }
        #endregion

        #region 查询
        /// <summary>
        /// 按照ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Dictionary<string, dynamic>> GetEvaluationbyID(Guid id)
        {
            var sql = @"SELECT [ID]
      ,[PName]
      ,[PSex]
      ,[Birthday]
      ,[Profession]
      ,[FIDCard]
      ,[Citizenship]
      ,[HJAddress]
      ,[FAddress]
      ,[Mailbox]
      ,[FTel]
      ,[FPhone]
      ,[FMarriage]
      ,[FContacts]
      ,[FContactsTel]
      ,[Relation]
      ,[Faith]
      ,[Language]
      ,[Education]
      ,[Medicare]
      ,[BloodType]
      ,[Transfusion]
      ,[DrugAllergy]
      ,[FoodAllergy]
      ,[Smoke]
      ,[Drink]
      ,[RestsBX]
      ,[RestsGMSW]
      ,[RestsGMYW]
      ,[RestsSmoke]
      ,[FCreateDate]
  FROM [T_PE_PatientEvaluations]
  WHERE id=@id";
            var par = new SqlParameter() { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.UniqueIdentifier, Value = id };
            return _db.GetList(sql, par);
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pevaton"></param>
        /// <returns></returns>
        public bool ModifyEvaluationbyID(PatientEvaluation pevaton)
        {
            var sql = @"  UPDATE    T_PE_PatientEvaluations
  SET       PName = @PName,
            PSex = @PSex,
            Birthday = @Birthday,
            Age = @Age,
            Profession = @Profession,
            FIDCard = @FIDCard,
            Citizenship = @Citizenship,
            HJAddress = @HJAddress,
            FAddress = @FAddress,
            Mailbox = @Mailbox,
            FTel = @FTel,
            FPhone = @FPhone,
            FMarriage = @FMarriage,
            FContacts = @FContacts,
            FContactsTel = @FContactsTel,
            Relation = @Relation,
            Faith = @Faith,
            Language = @Language,
            Education = @Education,
            Medicare = @Medicare,
            BloodType = @BloodType,
            Transfusion = @Transfusion,
            DrugAllergy = @DrugAllergy,
            FoodAllergy = @FoodAllergy,
            Smoke = @Smoke,
            Drink = @Drink,
            RestsBX = @RestsBX,
            RestsGMSW = @RestsGMSW,
            RestsGMYW = @RestsGMYW,
            RestsSmoke = @RestsSmoke
  WHERE     ID = @id";
            var pars = new List<SqlParameter>();
            pars.Add(new SqlParameter() { ParameterName = "@PName", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.PName) });
            pars.Add(new SqlParameter() { ParameterName = "@PSex", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.PSex) });
            pars.Add(new SqlParameter() { ParameterName = "@Birthday", SqlDbType = System.Data.SqlDbType.DateTime, Value = pevaton.Birthday });
            pars.Add(new SqlParameter() { ParameterName = "@Age", SqlDbType = System.Data.SqlDbType.Int, Value = pevaton.Age });
            pars.Add(new SqlParameter() { ParameterName = "@Profession", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Profession) });
            pars.Add(new SqlParameter() { ParameterName = "@FIDCard", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FIDCard) });
            pars.Add(new SqlParameter() { ParameterName = "@Citizenship", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Citizenship) });
            pars.Add(new SqlParameter() { ParameterName = "@HJAddress", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.HJAddress) });
            pars.Add(new SqlParameter() { ParameterName = "@FAddress", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FAddress) });
            pars.Add(new SqlParameter() { ParameterName = "@Mailbox", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Mailbox) });
            pars.Add(new SqlParameter() { ParameterName = "@FTel", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FTel) });
            pars.Add(new SqlParameter() { ParameterName = "@FPhone", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FPhone) });
            pars.Add(new SqlParameter() { ParameterName = "@FMarriage", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FMarriage) });
            pars.Add(new SqlParameter() { ParameterName = "@FContacts", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FContacts) });
            pars.Add(new SqlParameter() { ParameterName = "@FContactsTel", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FContactsTel) });
            pars.Add(new SqlParameter() { ParameterName = "@Relation", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Relation) });
            pars.Add(new SqlParameter() { ParameterName = "@Faith", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Faith) });
            pars.Add(new SqlParameter() { ParameterName = "@Language", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Language) });
            pars.Add(new SqlParameter() { ParameterName = "@Education", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Education) });
            pars.Add(new SqlParameter() { ParameterName = "@Medicare", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Medicare) });
            pars.Add(new SqlParameter() { ParameterName = "@BloodType", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.BloodType) });
            pars.Add(new SqlParameter() { ParameterName = "@Transfusion", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Transfusion) });
            pars.Add(new SqlParameter() { ParameterName = "@DrugAllergy", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.DrugAllergy) });
            pars.Add(new SqlParameter() { ParameterName = "@FoodAllergy", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.FoodAllergy) });
            pars.Add(new SqlParameter() { ParameterName = "@Smoke", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Smoke) });
            pars.Add(new SqlParameter() { ParameterName = "@Drink", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.Drink) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsBX", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsBX) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsGMSW", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsGMSW) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsGMYW", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsGMYW) });
            pars.Add(new SqlParameter() { ParameterName = "@RestsSmoke", SqlDbType = System.Data.SqlDbType.VarChar, Value = CheckNull(pevaton.RestsSmoke) });
            pars.Add(new SqlParameter() { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.UniqueIdentifier, Value = pevaton.ID });

            return _db.SavaData(sql, pars.ToArray()) > 0 ? true : false;

        }
        #endregion

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, dynamic>> GetAllEvaluation()
        {
            var sql = @"SELECT [ID]
      ,[PName]
      ,[PSex]
      ,[Birthday]
      ,[Age]
      ,[Profession]
      ,[FIDCard]
      ,[Citizenship]
      ,[HJAddress]
      ,[FAddress]
      ,[Mailbox]
      ,[FTel]
      ,[FPhone]
      ,[FMarriage]
      ,[FContacts]
      ,[FContactsTel]
      ,[Relation]
      ,[Faith]
      ,[Language]
      ,[Education]
      ,[Medicare]
      ,[BloodType]
      ,[Transfusion]
      ,[DrugAllergy]
      ,[FoodAllergy]
      ,[Smoke]
      ,[Drink]
      ,[RestsBX]
      ,[RestsGMSW]
      ,[RestsGMYW]
      ,[RestsSmoke]
      ,[FCreateDate]
  FROM [T_PE_PatientEvaluations]
ORDER BY FCreateDate";

            return _db.GetList(sql);
        }
    }
}
