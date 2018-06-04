//-------------------------------------------------------------------------
// <copyright  company="同程软件有限公司" file="TicketsBll.cs">
//  Copyright (c) 版本 V1
//  所属部门：景区B项目部-分销系统组
//  所属项目：分销系统-集团版
//  作    者：工具生成
//  创建日期：2014/11/5 9:43:47
//  功能描述：Tickets业务逻辑类
//  版本历史:
//      如有新增或修改请再次添加描述(格式：时间+作者+描述)
//</copyright>
//-------------------------------------------------------------------------

using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using TC.SmartTourism.Group.DBHelper;

namespace TC.SmartTourism.Group.DockingModel
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class TicketsEntity : TC.SmartTourism.Group.Model.ModelImp.BaseModel<TicketsEntity>
    {
       	public TicketsEntity()
		{
			TB_Name = TB_Tickets;
			Parm_Id = Parm_Tickets_Id;
			Parm_Version = Parm_Tickets_Version;
			Parm_All_Base = Parm_All;
			Sql_Insert = Sql_Tickets_Insert;
			Sql_Update = Sql_Tickets_Update;
			Sql_Delete = Sql_Tickets_Delete;
		}
       	#region Const of table Tickets
		/// <summary>
		/// Table Tickets
		/// </summary>
		public const string TB_Tickets = "Tickets";
		public const string Parm_All = "*";
		/// <summary>
		/// Parm Id
		/// </summary>
		public const string Parm_Tickets_Id = "Id";
		/// <summary>
		/// Parm Itemdesc
		/// </summary>
		public const string Parm_Tickets_Itemdesc = "Itemdesc";
		/// <summary>
		/// Parm Itemid
		/// </summary>
		public const string Parm_Tickets_Itemid = "Itemid";
		/// <summary>
		/// Parm Itemtype
		/// </summary>
		public const string Parm_Tickets_Itemtype = "Itemtype";
		/// <summary>
		/// Parm Price
		/// </summary>
		public const string Parm_Tickets_Price = "Price";
		/// <summary>
		/// Parm Validdate
		/// </summary>
		public const string Parm_Tickets_Validdate = "Validdate";
		/// <summary>
		/// Parm Validdays
		/// </summary>
		public const string Parm_Tickets_Validdays = "Validdays";
		/// <summary>
		/// Parm Validtype
		/// </summary>
		public const string Parm_Tickets_Validtype = "Validtype";
		/// <summary>
		/// Parm Version
		/// </summary>
		public const string Parm_Tickets_Version = "Version";
		/// <summary>
		/// Insert Query Of Tickets
		/// </summary>
		public const string Sql_Tickets_Insert = "insert into Tickets(Itemdesc,Itemid,Itemtype,Price,Validdate,Validdays,Validtype) values(@Itemdesc,@Itemid,@Itemtype,@Price,@Validdate,@Validdays,@Validtype);select @@identity;";
		/// <summary>
		/// Update Query Of Tickets
		/// </summary>
		public const string Sql_Tickets_Update = "update Tickets set Itemdesc=@Itemdesc,Itemid=@Itemid,Itemtype=@Itemtype,Price=@Price,Validdate=@Validdate,Validdays=@Validdays,Validtype=@Validtype where Id=@Id And Version=@Version;select @@rowcount;";
		/// <summary>
		/// Set RowStatus=0
		/// </summary>
		public const string Sql_Tickets_Delete = "update Tickets set RowStatus=0 where Id=@Id And Version=@Version;select @@rowcount;";
		#endregion

       	#region Properties
		private string _itemid = string.Empty;
		/// <summary>
		/// 票的数据库识别码
		/// </summary>
		public string Itemid
		{
			get{return _itemid ?? string.Empty;}
			set{_itemid = value;}
		}
		private string _itemdesc = string.Empty;
		/// <summary>
		/// 票名
		/// </summary>
		public string Itemdesc
		{
			get{return _itemdesc ?? string.Empty;}
			set{_itemdesc = value;}
		}
		private string _itemtype = string.Empty;
		/// <summary>
		/// 票类型
		/// </summary>
		public string Itemtype
		{
			get{return _itemtype ?? string.Empty;}
			set{_itemtype = value;}
		}
		private decimal _price;
		/// <summary>
		/// 票价
		/// </summary>
		public decimal Price
		{
			get{return _price;}
			set{_price = value;}
		}
		private int _validtype;
		/// <summary>
		/// 有效期验证方式 0--有效天数 1--有效日期到某个日期
		/// </summary>
		public int Validtype
		{
			get{return _validtype;}
			set{_validtype = value;}
		}
		private int _validdays;
		/// <summary>
		/// 有效天数   (当有效期验证方式为0时取此值)
		/// </summary>
		public int Validdays
		{
			get{return _validdays;}
			set{_validdays = value;}
		}
		private DateTime _validdate = MinDate;
		/// <summary>
		/// 有效期到某天 (当有效期验证方式为1时取此值)
		/// </summary>
		public DateTime Validdate
		{
			get{return _validdate;}
			set{_validdate = value;}
		}
		#endregion
	
		/// <summary>
        /// 根据DataRow给实体赋值
        /// </summary>
        /// <param name="dr">DataRow</param>
        /// <returns>实体</returns>
		public override TicketsEntity SetModelValueByDataRow(DataRow dr)
      	{
            IList<string> fields = new List<string> {"*"};
   	    	return SetModelValueByDataRow(dr,fields);
        }

		/// <summary>
        /// 根据DataRow给实体相应字段赋值
        /// </summary>
        /// <param name="dr">DataRow</param>
        /// <param name="fields">字段集合</param>
        /// <returns>实体</returns>
		public override TicketsEntity SetModelValueByDataRow(DataRow dr, IList<string> fields)
        {
            var tmp = new TicketsEntity();
          			if (fields.Contains(Parm_Tickets_Id) || fields.Contains("*"))
				tmp.Id = int.Parse(dr[Parm_Tickets_Id].ToString());
			if (fields.Contains(Parm_Tickets_Itemid) || fields.Contains("*"))
				tmp.Itemid = dr[Parm_Tickets_Itemid].ToString();
			if (fields.Contains(Parm_Tickets_Itemdesc) || fields.Contains("*"))
				tmp.Itemdesc = dr[Parm_Tickets_Itemdesc].ToString();
			if (fields.Contains(Parm_Tickets_Itemtype) || fields.Contains("*"))
				tmp.Itemtype = dr[Parm_Tickets_Itemtype].ToString();
			if (fields.Contains(Parm_Tickets_Price) || fields.Contains("*"))
				tmp.Price = decimal.Parse(dr[Parm_Tickets_Price].ToString());
			if (fields.Contains(Parm_Tickets_Validtype) || fields.Contains("*"))
				tmp.Validtype = int.Parse(dr[Parm_Tickets_Validtype].ToString());
			if (fields.Contains(Parm_Tickets_Validdays) || fields.Contains("*"))
				tmp.Validdays = int.Parse(dr[Parm_Tickets_Validdays].ToString());
			if (fields.Contains(Parm_Tickets_Validdate) || fields.Contains("*"))
				tmp.Validdate = DateTime.Parse(dr[Parm_Tickets_Validdate].ToString());
			if (fields.Contains(Parm_Tickets_Version) || fields.Contains("*"))
			{
				var bts = (byte[])(dr[Parm_Tickets_Version]);
				Array.Reverse(bts);
				tmp.Version = BitConverter.ToInt64(bts, 0);
			}

	       return tmp;
        }

		/// <summary>
        /// 通过实体对参数赋值用于新增
        /// </summary>
        /// <param name="tickets">实体</param>
        /// <param name="parms">参数</param>
        /// <returns>SqlParameter[] 集合</returns>
		public override SqlParameter[] SetParmsValueByModelForAdd(TicketsEntity tickets, SqlParameter[] parms)
		{
            				parms[0].Value = tickets.Itemid;
				parms[1].Value = tickets.Itemdesc;
				parms[2].Value = tickets.Itemtype;
				parms[3].Value = tickets.Price;
				parms[4].Value = tickets.Validtype;
				parms[5].Value = tickets.Validdays;
				parms[6].Value = tickets.Validdate;

             return parms;
        }

		/// <summary>
        /// 通过实体对参数(Id,Version)赋值用于修改
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="parms">参数</param>
        /// <returns>SqlParameter[] 集合</returns>
		public override SqlParameter[] SetParmsValueByModelForUpdate(TicketsEntity model, SqlParameter[] parms)
        {
            parms = SetParmsValueByModelForAdd(model, parms);
            parms[parms.Length - 2] = new SqlParameter(Parm_Tickets_Id, model.Id);
            parms[parms.Length - 1] = new SqlParameter(Parm_Tickets_Version, model.Version);
            return parms;
        }

        	/// <summary>
        /// 获取一个给SQL语句传参用的参数集合
        /// </summary>
        /// <returns>SqlParameter[] 集合</returns>
		public override SqlParameter[] GetParms()
        {
	     	try
	     	{
				var parms = SqlHelperParameterCache.GetCachedParameterSet(SqlHelper.SQLConnStringWrite, Sql_Tickets_Insert);
				if (parms == null)
				{
					parms = new []{
	                 								new SqlParameter(Parm_Tickets_Itemid, SqlDbType.VarChar, 50),
					new SqlParameter(Parm_Tickets_Itemdesc, SqlDbType.NVarChar, 200),
					new SqlParameter(Parm_Tickets_Itemtype, SqlDbType.NVarChar, 200),
					new SqlParameter(Parm_Tickets_Price, SqlDbType.Decimal, 18),
					new SqlParameter(Parm_Tickets_Validtype, SqlDbType.Int, 10),
					new SqlParameter(Parm_Tickets_Validdays, SqlDbType.Int, 10),
					new SqlParameter(Parm_Tickets_Validdate, SqlDbType.DateTime, 23)

				};
					SqlHelperParameterCache.CacheParameterSet(SqlHelper.SQLConnStringWrite, Sql_Tickets_Insert, parms);
				}
				return parms;
	    	}
            catch (Exception e)
            {
               	throw new Exception("获取查询参数时出错！", e);
            }
        }
    }
}
