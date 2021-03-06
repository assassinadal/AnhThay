﻿///************************************************
/// Generated by: TuyenNT
/// Date: 30/01/2015 08:15:43
/// Goal: Create Form for V_RPT_BAO_CAO_TINH_HINH_DI_HOC
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs : Form
    {
        public f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs()
        {
            InitializeComponent();
            format_controls();
            m_dat_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            m_dat_den_ngay.Value = DateTime.Now.Date;
        }
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            HO_TEN = 4
,
            MA_LOP_MON = 1
                ,
            MO_TA = 2
                ,
            TONG_SO_BUOI_DI_HOC = 5
                , MA_HOC_SINH = 3

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_TINH_HINH_DI_HOC m_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
        US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC m_us = new US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            m_fg.Cols.Frozen = (int)e_col_Number.TONG_SO_BUOI_DI_HOC;

            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds, "where TRANG_THAI_LOP_MON = 88");

            //DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            //v_dr[DM_LOP_MON.ID] = -1;
            //v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";

            //v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop_mon.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;

            //m_cbo_lop_mon.SelectedIndex = 0;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_lop_mon();
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_DI_HOC.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_DI_HOC.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_DI_HOC.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_DI_HOC.TONG_SO_BUOI_DI_HOC, e_col_Number.TONG_SO_BUOI_DI_HOC);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_DI_HOC.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_TINH_HINH_DI_HOC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds.Clear();
            m_ds.EnforceConstraints = false;

            m_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();

            m_us.FillDataset(m_ds, m_dat_tu_ngay.Value
                                , m_dat_den_ngay.Value
                                , CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue)
                                , m_txt_tim_kien.Text.Trim());

            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.Redraw = true;
            CGridUtils.MakeSoTT(0, m_fg);
            load_cot_dong_tung_ngay_hoc(m_ds);
        }

        private void load_cot_dong_tung_ngay_hoc(DS_V_RPT_BAO_CAO_TINH_HINH_DI_HOC ip_ds_rpt)
        {
            //Buoc 0: Xoa cot dong
            if (m_fg.Cols.Count > 6)
            {
                int v_tong_so_cot = m_fg.Cols.Count;
                for (int i = 6; i < v_tong_so_cot; i++)
                {
                    m_fg.Cols.Remove(m_fg.Cols.Count - 1);
                }
            }

            //Buoc 1: Lay du lieu cac ban ghi trong GD_HOC do len Dataset
            DataSet v_ds_gd_hoc = new DataSet();
            v_ds_gd_hoc.Tables.Add();
            US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC v_us_gd_hoc = new US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
            v_us_gd_hoc.FillDuLieuDiemDanh(v_ds_gd_hoc
                                        , m_dat_tu_ngay.Value
                                        , m_dat_den_ngay.Value
                                        , CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
            DataView v_dv = v_ds_gd_hoc.Tables[0].DefaultView;

            //Buoc 2:Insert cac ngay hoc cua lop do
            //Buoc 2.1: Lay du lieu cac ngay hoc
            DataSet v_ds_ngay_hoc = new DataSet();
            v_ds_ngay_hoc.Tables.Add();
            US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC v_us_ngay_hoc = new US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
            v_us_ngay_hoc.FillDuLieuNgayHoc(v_ds_ngay_hoc
                                            , m_dat_tu_ngay.Value
                                            , m_dat_den_ngay.Value
                                            , CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
            //Buoc 2.2: Insert cac cot vao grid
            int v_count_col_grid = m_fg.Cols.Count;
            for (int i = 0; i < v_ds_ngay_hoc.Tables[0].Rows.Count; i++)//For tren cac ngay hoc
            {
                m_fg.Cols.Insert(v_count_col_grid);
                DateTime v_dat = CIPConvert.ToDatetime(v_ds_ngay_hoc.Tables[0].Rows[i][0].ToString().Substring(0, 10));
                m_fg.Cols[v_count_col_grid].Caption = v_ds_ngay_hoc.Tables[0].Rows[i][0].ToString().Substring(0, 10);
                m_fg.Cols[v_count_col_grid].DataType = typeof(Boolean);

               
                for (int v_i_current_row = m_fg.Rows.Fixed; v_i_current_row < m_fg.Rows.Count; v_i_current_row++)
                {
                    US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC v_us_di_hoc = new US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
                    grid2us_object(v_us_di_hoc, v_i_current_row);
                    foreach (DataRow v_dr in v_ds_gd_hoc.Tables[0].Rows)
                    {
                        if (v_dr["NGAY_HOC"].ToString() == v_dat.ToString() && v_dr["ID_HOC_SINH"].ToString() == v_us_di_hoc.dcID_HOC_SINH.ToString())
                        {
                            m_fg.SetCellCheck(v_i_current_row, v_count_col_grid, CheckEnum.Checked);
                        }
                    }
                }
                v_count_col_grid++;
            }
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_bao_cao_tinh_hinh_di_hoc()
        {
            //	frm_440_DE v_fDE = new  frm_440_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_bao_cao_tinh_hinh_di_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_440_DE v_fDE = new frm_440_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_bao_cao_tinh_hinh_di_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC v_us = new US_V_RPT_BAO_CAO_TINH_HINH_DI_HOC();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_rpt_bao_cao_tinh_hinh_di_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_440_DE v_fDE = new frm_440_DE();			
            //	v_fDE.display(m_us);
        }

        private void xuat_excel() {
            var v_start_row = 8;
            var v_start_col = 2;
            var v_obj_excel_rpt = new CExcelReport("f440_bao_cao_diem_danh.xlsx", v_start_row, v_start_col);
            v_obj_excel_rpt.AddFindAndReplaceItem("<tu_ngay>", string.Format("{0}/{1}/{2}", m_dat_tu_ngay.Value.Date.Day, m_dat_tu_ngay.Value.Month, m_dat_tu_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<den_ngay>", string.Format("{0}/{1}/{2}", m_dat_den_ngay.Value.Day, m_dat_den_ngay.Value.Month, m_dat_den_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<ten_lop>", m_cbo_lop_mon.Text);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, false);
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            this.KeyDown += f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs_KeyDown;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e) {
            try {
                xuat_excel();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_rpt_bao_cao_tinh_hinh_di_hoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_rpt_bao_cao_tinh_hinh_di_hoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_rpt_bao_cao_tinh_hinh_di_hoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_rpt_bao_cao_tinh_hinh_di_hoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
