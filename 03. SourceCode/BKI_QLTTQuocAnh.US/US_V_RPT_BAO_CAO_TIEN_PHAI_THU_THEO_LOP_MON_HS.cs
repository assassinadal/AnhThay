///************************************************
/// Generated by: vinhnt
/// Date: 22/01/2015 03:08:36
/// Goal: Create User Service Class for V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS
///************************************************
/// <summary>
/// Create User Service Class for V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace BKI_QLTTQuocAnh.US{

public class US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS : US_Object
{
	private const string c_TableName = "V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS";
#region "Public Properties"
	public string strMA_LOP_MON 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_LOP_MON", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_LOP_MON"] = value;
		}
	}

	public bool IsMA_LOP_MONNull() 
	{
		return pm_objDR.IsNull("MA_LOP_MON");
	}

	public void SetMA_LOP_MONNull() {
		pm_objDR["MA_LOP_MON"] = System.Convert.DBNull;
	}

	public string strMA_DOI_TUONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DOI_TUONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DOI_TUONG"] = value;
		}
	}

	public bool IsMA_DOI_TUONGNull() 
	{
		return pm_objDR.IsNull("MA_DOI_TUONG");
	}

	public void SetMA_DOI_TUONGNull() {
		pm_objDR["MA_DOI_TUONG"] = System.Convert.DBNull;
	}

	public decimal dcID_HOC_SINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HOC_SINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HOC_SINH"] = value;
		}
	}

	public bool IsID_HOC_SINHNull()	{
		return pm_objDR.IsNull("ID_HOC_SINH");
	}

	public void SetID_HOC_SINHNull() {
		pm_objDR["ID_HOC_SINH"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public decimal dcPHAI_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "PHAI_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["PHAI_THU"] = value;
		}
	}

	public bool IsPHAI_THUNull()	{
		return pm_objDR.IsNull("PHAI_THU");
	}

	public void SetPHAI_THUNull() {
		pm_objDR["PHAI_THU"] = System.Convert.DBNull;
	}

	public decimal dcTHUC_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THUC_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THUC_THU"] = value;
		}
	}

	public bool IsTHUC_THUNull()	{
		return pm_objDR.IsNull("THUC_THU");
	}

	public void SetTHUC_THUNull() {
		pm_objDR["THUC_THU"] = System.Convert.DBNull;
	}

	public decimal dcGIAM_TRU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIAM_TRU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIAM_TRU"] = value;
		}
	}

	public bool IsGIAM_TRUNull()	{
		return pm_objDR.IsNull("GIAM_TRU");
	}

	public void SetGIAM_TRUNull() {
		pm_objDR["GIAM_TRU"] = System.Convert.DBNull;
	}

	public decimal dcCON_PHAI_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CON_PHAI_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CON_PHAI_THU"] = value;
		}
	}

	public bool IsCON_PHAI_THUNull()	{
		return pm_objDR.IsNull("CON_PHAI_THU");
	}

	public void SetCON_PHAI_THUNull() {
		pm_objDR["CON_PHAI_THU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS() 
	{
		pm_objDS = new DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS(decimal i_dbID) 
	{
		pm_objDS = new DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDataset(DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS m_ds
           , DateTime ip_dat_from_date
           , DateTime ip_dat_to_date
           , string ip_str_ma_lop_mon
           , string ip_str_search)
    {
        CStoredProc v_obj_pr = new CStoredProc("f470_bao_cao_tien_phai_thu_theo_hoc_sinh");
        v_obj_pr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_from_date);
        v_obj_pr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_to_date);
        v_obj_pr.addNVarcharInputParam("@ip_str_ma_lop_mon", ip_str_ma_lop_mon);
        v_obj_pr.addNVarcharInputParam("@ip_str_search", ip_str_search);
        v_obj_pr.fillDataSetByCommand(this,m_ds);
    }
}
}