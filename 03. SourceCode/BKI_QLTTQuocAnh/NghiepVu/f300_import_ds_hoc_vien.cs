///************************************************
/// Generated by: TuyenNT
/// Date: 06/04/2015 08:12:23
/// Goal: Create Form for EXCEL_IMPORT_HOC_VIEN
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

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
using System.Diagnostics;

namespace BKI_QLTTQuocAnh {



    public class f300_import_ds_hoc_vien : System.Windows.Forms.Form {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        private LinkLabel m_llbl_mau_import;
        private Label label9;
        private Label label7;
        private Label m_lbl_green;
        private Label m_lbl_pink;
        internal SIS.Controls.Button.SiSButton m_cmd_save_data;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_file_excel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label m_lbl_header;
        private OpenFileDialog m_ofd_exel_file;
        private Label m_lbl_loading_mes;
        private Label label1;
        private Label label6;
        internal SIS.Controls.Button.SiSButton m_cmd_kiem_tra_du_lieu;
        private System.ComponentModel.IContainer components;

        public f300_import_ds_hoc_vien() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f300_import_ds_hoc_vien));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_cmd_kiem_tra_du_lieu = new SIS.Controls.Button.SiSButton();
            this.m_llbl_mau_import = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_lbl_green = new System.Windows.Forms.Label();
            this.m_lbl_pink = new System.Windows.Forms.Label();
            this.m_cmd_save_data = new SIS.Controls.Button.SiSButton();
            this.m_cmd_chon_file_excel = new SIS.Controls.Button.SiSButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_ofd_exel_file = new System.Windows.Forms.OpenFileDialog();
            this.m_lbl_loading_mes = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(859, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(503, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(591, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            this.m_cmd_view.Visible = false;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(679, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            this.m_cmd_delete.Visible = false;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(767, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Visible = false;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 110);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(859, 263);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.m_cmd_kiem_tra_du_lieu);
            this.panel1.Controls.Add(this.m_llbl_mau_import);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.m_lbl_green);
            this.panel1.Controls.Add(this.m_lbl_pink);
            this.panel1.Controls.Add(this.m_cmd_save_data);
            this.panel1.Controls.Add(this.m_cmd_chon_file_excel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 110);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "-->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Bước 3:";
            // 
            // m_cmd_kiem_tra_du_lieu
            // 
            this.m_cmd_kiem_tra_du_lieu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_kiem_tra_du_lieu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_kiem_tra_du_lieu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_kiem_tra_du_lieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_kiem_tra_du_lieu.ImageIndex = 13;
            this.m_cmd_kiem_tra_du_lieu.ImageList = this.ImageList;
            this.m_cmd_kiem_tra_du_lieu.Location = new System.Drawing.Point(302, 66);
            this.m_cmd_kiem_tra_du_lieu.Name = "m_cmd_kiem_tra_du_lieu";
            this.m_cmd_kiem_tra_du_lieu.Size = new System.Drawing.Size(121, 28);
            this.m_cmd_kiem_tra_du_lieu.TabIndex = 43;
            this.m_cmd_kiem_tra_du_lieu.Text = "Kiểm tra dữ liệu";
            // 
            // m_llbl_mau_import
            // 
            this.m_llbl_mau_import.AutoSize = true;
            this.m_llbl_mau_import.Location = new System.Drawing.Point(12, 53);
            this.m_llbl_mau_import.Name = "m_llbl_mau_import";
            this.m_llbl_mau_import.Size = new System.Drawing.Size(77, 13);
            this.m_llbl_mau_import.TabIndex = 42;
            this.m_llbl_mau_import.TabStop = true;
            this.m_llbl_mau_import.Text = "Tải mẫu Import";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Mã học viên đã có";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Dữ liệu trống";
            // 
            // m_lbl_green
            // 
            this.m_lbl_green.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.m_lbl_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_green.Location = new System.Drawing.Point(684, 80);
            this.m_lbl_green.Name = "m_lbl_green";
            this.m_lbl_green.Size = new System.Drawing.Size(56, 23);
            this.m_lbl_green.TabIndex = 41;
            // 
            // m_lbl_pink
            // 
            this.m_lbl_pink.BackColor = System.Drawing.Color.Pink;
            this.m_lbl_pink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_pink.Location = new System.Drawing.Point(684, 51);
            this.m_lbl_pink.Name = "m_lbl_pink";
            this.m_lbl_pink.Size = new System.Drawing.Size(56, 23);
            this.m_lbl_pink.TabIndex = 41;
            // 
            // m_cmd_save_data
            // 
            this.m_cmd_save_data.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save_data.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save_data.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save_data.ImageIndex = 16;
            this.m_cmd_save_data.ImageList = this.ImageList;
            this.m_cmd_save_data.Location = new System.Drawing.Point(494, 66);
            this.m_cmd_save_data.Name = "m_cmd_save_data";
            this.m_cmd_save_data.Size = new System.Drawing.Size(153, 28);
            this.m_cmd_save_data.TabIndex = 39;
            this.m_cmd_save_data.Text = "Lưu danh sách học viên";
            // 
            // m_cmd_chon_file_excel
            // 
            this.m_cmd_chon_file_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_file_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_file_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_file_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_file_excel.ImageIndex = 19;
            this.m_cmd_chon_file_excel.ImageList = this.ImageList;
            this.m_cmd_chon_file_excel.Location = new System.Drawing.Point(113, 66);
            this.m_cmd_chon_file_excel.Name = "m_cmd_chon_file_excel";
            this.m_cmd_chon_file_excel.Size = new System.Drawing.Size(121, 28);
            this.m_cmd_chon_file_excel.TabIndex = 33;
            this.m_cmd_chon_file_excel.Text = "Chọn File Excel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "-->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Bước 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bước 1:";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(859, 37);
            this.m_lbl_header.TabIndex = 25;
            this.m_lbl_header.Text = "NHẬP DANH SÁCH HỌC VIÊN TỪ FILE EXCEL";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_ofd_exel_file
            // 
            this.m_ofd_exel_file.FileName = "openFileDialog1";
            // 
            // m_lbl_loading_mes
            // 
            this.m_lbl_loading_mes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_lbl_loading_mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lbl_loading_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading_mes.Location = new System.Drawing.Point(263, 170);
            this.m_lbl_loading_mes.Name = "m_lbl_loading_mes";
            this.m_lbl_loading_mes.Size = new System.Drawing.Size(301, 68);
            this.m_lbl_loading_mes.TabIndex = 26;
            this.m_lbl_loading_mes.Text = "Vui lòng đợi trong giây lát ...";
            this.m_lbl_loading_mes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_lbl_loading_mes.Visible = false;
            // 
            // f300_import_ds_hoc_vien
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(859, 409);
            this.Controls.Add(this.m_lbl_loading_mes);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f300_import_ds_hoc_vien";
            this.Text = "F300 - Nhập DS Học viên từ Excel";
            this.Load += new System.EventHandler(this.f300_import_ds_hoc_vien_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            EMAIL = 6
,
            SĐT = 8
                ,
            STT = 1
                ,
            MA_HOC_VIEN = 2
                ,
            HO_DEM = 3
                ,
            TEN = 4
                ,
            TRUONG_DANG_HOC = 5
                , DIA_CHI = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_EXCEL_IMPORT_HOC_VIEN m_ds = new DS_EXCEL_IMPORT_HOC_VIEN();
        US_EXCEL_IMPORT_HOC_VIEN m_us = new US_EXCEL_IMPORT_HOC_VIEN();
        bool m_flag_du_lieu_is_ok = true;
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());

            this.m_lbl_pink.BackColor = System.Drawing.Color.Pink;
            this.m_lbl_pink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_green.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.m_lbl_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.AllowEditing = true;


            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.EMAIL, e_col_Number.EMAIL);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.SĐT, e_col_Number.SĐT);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.STT, e_col_Number.STT);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.MA_HOC_VIEN, e_col_Number.MA_HOC_VIEN);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.HO_DEM, e_col_Number.HO_DEM);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.TEN, e_col_Number.TEN);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.TRUONG_DANG_HOC, e_col_Number.TRUONG_DANG_HOC);
            v_htb.Add(EXCEL_IMPORT_HOC_VIEN.DIA_CHI, e_col_Number.DIA_CHI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.EXCEL_IMPORT_HOC_VIEN.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid() {
            m_ds = new DS_EXCEL_IMPORT_HOC_VIEN();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_EXCEL_IMPORT_HOC_VIEN i_us
            , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_EXCEL_IMPORT_HOC_VIEN i_us
            , int i_grid_row) {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_excel_import_hoc_vien() {
            //	f300_import_ds_hoc_vien_DE v_fDE = new  f300_import_ds_hoc_vien_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_excel_import_hoc_vien() {
            if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f300_import_ds_hoc_vien_DE v_fDE = new f300_import_ds_hoc_vien_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_excel_import_hoc_vien() {
            if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if(BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_EXCEL_IMPORT_HOC_VIEN v_us = new US_EXCEL_IMPORT_HOC_VIEN();
            grid2us_object(v_us, m_fg.Row);
            try {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch(Exception v_e) {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_excel_import_hoc_vien() {
            if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f300_import_ds_hoc_vien_DE v_fDE = new f300_import_ds_hoc_vien_DE();			
            //	v_fDE.display(m_us);
        }


        private void load_file_excel() {
            if(m_ofd_exel_file.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                try {
                    // Reset lại ds mới nếu chọn lại file excel khác
                    m_ds = new DS_EXCEL_IMPORT_HOC_VIEN();

                    m_lbl_loading_mes.Visible = true;
                    CExcelReport v_excel_rpt = new CExcelReport(m_ofd_exel_file.FileName);

                    m_ds.EnforceConstraints = false;
                    v_excel_rpt.Export2DatasetDS_by_DucVT(m_ds, m_ds.EXCEL_IMPORT_HOC_VIEN.TableName, 2);

                    m_fg.Redraw = false;

                    //Gán DataSource
                    //m_fg.DataSource = m_ds.DM_NHAN_SU;

                    CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
                    m_fg.Redraw = true;
                    m_lbl_loading_mes.Visible = false;

                }
                catch(Exception v_e) {
                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }
        private void excel_2_us_dm_hoc_vien(US_EXCEL_IMPORT_HOC_VIEN ip_us_excel, US_DM_HOC_SINH ip_us_hv) {
            ip_us_hv.dcID_LOAI_DOI_TUONG = CONST_ID_LOAI_DOI_TUONG.ID_HOC_SINH;
            ip_us_hv.strMA_DOI_TUONG = ip_us_excel.strMA_HOC_VIEN;
            ip_us_hv.strHO = ip_us_excel.strHO_DEM;
            ip_us_hv.strTEN = ip_us_excel.strTEN;
            ip_us_hv.strTRUONG_DANG_HOC = ip_us_excel.strTRUONG_DANG_HOC;
            ip_us_hv.strEMAIL_HS = ip_us_excel.strEMAIL;
            ip_us_hv.strDIA_CHI = ip_us_excel.strDIA_CHI;
            ip_us_hv.strSDT_HS = ip_us_excel.strSĐT;
        }
        private void kiem_tra_du_lieu(DS_EXCEL_IMPORT_HOC_VIEN ip_ds) {
            m_flag_du_lieu_is_ok = true;
            CellStyle v_style_not_ok = m_fg.Styles.Add("LoiDuLieu");
            v_style_not_ok.BackColor = Color.Pink;
            CellStyle v_style_ok_ma_hv = m_fg.Styles.Add("Ma_HV");
            v_style_ok_ma_hv.BackColor = Color.DeepSkyBlue;
            CellStyle v_style_ok = m_fg.Styles.Add("OK");
            v_style_ok.BackColor = Color.White;
            //Buoc 1: Check null
            for(int i = m_fg.Rows.Fixed; i < m_fg.Rows.Count; i++) {
                for(int j = m_fg.Cols.Fixed; j < m_fg.Cols.Count; j++) {
                    if(m_fg.Rows[i][j] == null || m_fg.Rows[i][j].ToString() == "") {
                        m_fg.SetCellStyle(i, j, v_style_not_ok);
                        m_flag_du_lieu_is_ok = false;
                    }
                    else {
                        m_fg.SetCellStyle(i, (int)e_col_Number.MA_HOC_VIEN, v_style_ok);
                    }
                }
            }
            //Buoc 2: Check Ma hoc vien da ton tai chua
            DS_DM_HOC_SINH v_ds_hs = new DS_DM_HOC_SINH();
            v_ds_hs.Clear();
            v_ds_hs.EnforceConstraints = false;
            US_DM_HOC_SINH v_us_hs = new US_DM_HOC_SINH();
            v_us_hs.FillDataset(v_ds_hs);
            DataView v_dv_db = v_ds_hs.DM_HOC_SINH.DefaultView;
            v_dv_db.Sort = "MA_DOI_TUONG";
            for(int i = m_fg.Rows.Fixed; i < m_fg.Rows.Count; i++) {
                int v_row = v_dv_db.Find(m_fg.Rows[i][(int)e_col_Number.MA_HOC_VIEN].ToString());
                if(v_row > 0) {
                    m_flag_du_lieu_is_ok = false;
                    m_fg.SetCellStyle(i, (int)e_col_Number.MA_HOC_VIEN, v_style_ok_ma_hv);
                }
                else {
                    m_fg.SetCellStyle(i, (int)e_col_Number.MA_HOC_VIEN, v_style_ok);
                }
            }
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_chon_file_excel.Click += m_cmd_chon_file_excel_Click;
            m_llbl_mau_import.Click += m_llbl_mau_import_Click;
            m_cmd_save_data.Click += m_cmd_save_data_Click;
            m_cmd_kiem_tra_du_lieu.Click += m_cmd_kiem_tra_du_lieu_Click;
        }

        void m_cmd_kiem_tra_du_lieu_Click(object sender, EventArgs e) {
            try {
                kiem_tra_du_lieu(m_ds);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_data_Click(object sender, EventArgs e) {
            try {
                if(m_flag_du_lieu_is_ok == false) {
                    BaseMessages.MsgBox_Error("Bạn kiểm tra dữ liệu trước nhé!");
                    return;
                }
                m_us.BeginTransaction();

                US_DM_HOC_SINH v_us_hv = new US_DM_HOC_SINH();
                for(int i_grid_row = 1; i_grid_row < m_fg.Rows.Count; i_grid_row++) {
                    grid2us_object(m_us, i_grid_row);
                    excel_2_us_dm_hoc_vien(m_us, v_us_hv);
                    v_us_hv.Insert();
                    v_us_hv.ClearAllFields();
                }
                m_us.CommitTransaction();
                BaseMessages.MsgBox_Infor("Lưu dữ liệu học viên thành công");
            }
            catch(Exception v_e) {
                if(m_us.is_having_transaction()) {
                    m_us.Rollback();
                }
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_llbl_mau_import_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://drive.google.com/file/d/0B5VALXmEILhMV0RBem4wSXRrWE0/view?usp=sharing");
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_file_excel_Click(object sender, EventArgs e) {
            try {
                load_file_excel();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f300_import_ds_hoc_vien_Load(object sender, System.EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                insert_excel_import_hoc_vien();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e) {
            try {
                update_excel_import_hoc_vien();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e) {
            try {
                delete_excel_import_hoc_vien();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e) {
            try {
                view_excel_import_hoc_vien();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

