﻿namespace wirelesssacler
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_import = new CCWin.SkinControl.SkinButton();
            this.btn_reload = new CCWin.SkinControl.SkinButton();
            this.btn_plus = new CCWin.SkinControl.SkinButton();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.DG_List = new CCWin.SkinControl.SkinDataGridView();
            this.btn_falsh = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_d_zd = new System.Windows.Forms.RadioButton();
            this.btn_d_bj = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_List)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_import.BaseColor = System.Drawing.Color.Transparent;
            this.btn_import.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_import.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_import.DownBack")));
            this.btn_import.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_import.ForeColor = System.Drawing.Color.Green;
            this.btn_import.IsDrawGlass = false;
            this.btn_import.Location = new System.Drawing.Point(363, 24);
            this.btn_import.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_import.MouseBack")));
            this.btn_import.Name = "btn_import";
            this.btn_import.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_import.NormlBack")));
            this.btn_import.Size = new System.Drawing.Size(35, 36);
            this.btn_import.TabIndex = 7;
            this.btn_import.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinToolTip1.SetToolTip(this.btn_import, "导出设备列表");
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reload.BackColor = System.Drawing.Color.Transparent;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reload.BaseColor = System.Drawing.Color.Transparent;
            this.btn_reload.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_reload.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_reload.DownBack")));
            this.btn_reload.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_reload.ForeColor = System.Drawing.Color.Green;
            this.btn_reload.IsDrawGlass = false;
            this.btn_reload.Location = new System.Drawing.Point(288, 24);
            this.btn_reload.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_reload.MouseBack")));
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_reload.NormlBack")));
            this.btn_reload.Size = new System.Drawing.Size(35, 36);
            this.btn_reload.TabIndex = 6;
            this.btn_reload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinToolTip1.SetToolTip(this.btn_reload, "刷新列表");
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_falsh_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_plus.BaseColor = System.Drawing.Color.Transparent;
            this.btn_plus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_plus.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_plus.DownBack")));
            this.btn_plus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_plus.ForeColor = System.Drawing.Color.Green;
            this.btn_plus.IsDrawGlass = false;
            this.btn_plus.Location = new System.Drawing.Point(218, 24);
            this.btn_plus.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_plus.MouseBack")));
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_plus.NormlBack")));
            this.btn_plus.Size = new System.Drawing.Size(35, 36);
            this.btn_plus.TabIndex = 5;
            this.btn_plus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinToolTip1.SetToolTip(this.btn_plus, "删除该设备");
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.deletedev_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.BaseColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_add.DownBack")));
            this.btn_add.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_add.ForeColor = System.Drawing.Color.Green;
            this.btn_add.IsDrawGlass = false;
            this.btn_add.Location = new System.Drawing.Point(145, 24);
            this.btn_add.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_add.MouseBack")));
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_add.NormlBack")));
            this.btn_add.Size = new System.Drawing.Size(35, 36);
            this.btn_add.TabIndex = 4;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinToolTip1.SetToolTip(this.btn_add, "添加设备");
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.AddDev_Click);
            // 
            // DG_List
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.DG_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_List.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DG_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DG_List.ColumnFont = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_List.ColumnSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(104)))));
            this.DG_List.ColumnSelectForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_List.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_List.EnableHeadersVisualStyles = false;
            this.DG_List.GridColor = System.Drawing.Color.White;
            this.DG_List.HeadFont = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_List.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DG_List.LineNumberForeColor = System.Drawing.Color.DodgerBlue;
            this.DG_List.Location = new System.Drawing.Point(3, 63);
            this.DG_List.Name = "DG_List";
            this.DG_List.ReadOnly = true;
            this.DG_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_List.RowHeadersVisible = false;
            this.DG_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(176)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.DG_List.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_List.RowTemplate.Height = 23;
            this.DG_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_List.Size = new System.Drawing.Size(480, 350);
            this.DG_List.SkinGridColor = System.Drawing.Color.White;
            this.DG_List.TabIndex = 1;
            this.DG_List.TitleBack = null;
            this.DG_List.TitleBackColorBegin = System.Drawing.Color.White;
            this.DG_List.TitleBackColorEnd = System.Drawing.Color.White;
            this.DG_List.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DG_List_CellBeginEdit);
            this.DG_List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_List_CellEndEdit);
            this.DG_List.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_List_CellMouseDown);
            // 
            // btn_falsh
            // 
            this.btn_falsh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_falsh.BackColor = System.Drawing.Color.Transparent;
            this.btn_falsh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.btn_falsh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_falsh.DownBack = null;
            this.btn_falsh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_falsh.ForeColor = System.Drawing.Color.White;
            this.btn_falsh.IsDrawBorder = false;
            this.btn_falsh.Location = new System.Drawing.Point(358, 11);
            this.btn_falsh.MouseBack = null;
            this.btn_falsh.Name = "btn_falsh";
            this.btn_falsh.NormlBack = null;
            this.btn_falsh.Size = new System.Drawing.Size(88, 35);
            this.btn_falsh.TabIndex = 3;
            this.btn_falsh.Text = "刷新列表";
            this.btn_falsh.UseVisualStyleBackColor = false;
            this.btn_falsh.Click += new System.EventHandler(this.btn_falsh_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(9, 20);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(306, 20);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "提示:选中编辑模式，可以直接修改添加删除设备";
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skinToolTip1.BackColor2 = System.Drawing.Color.Green;
            this.skinToolTip1.Border = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            this.skinToolTip1.TipFore = System.Drawing.Color.Yellow;
            this.skinToolTip1.TitleFore = System.Drawing.Color.Yellow;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DG_List, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 486);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_d_zd);
            this.panel1.Controls.Add(this.btn_d_bj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_d_zd
            // 
            this.btn_d_zd.AutoSize = true;
            this.btn_d_zd.Checked = true;
            this.btn_d_zd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_d_zd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_d_zd.Location = new System.Drawing.Point(6, 3);
            this.btn_d_zd.Name = "btn_d_zd";
            this.btn_d_zd.Size = new System.Drawing.Size(92, 25);
            this.btn_d_zd.TabIndex = 12;
            this.btn_d_zd.TabStop = true;
            this.btn_d_zd.Text = "只读模式";
            this.btn_d_zd.UseVisualStyleBackColor = true;
            this.btn_d_zd.CheckedChanged += new System.EventHandler(this.btn_d_zd_CheckedChanged);
            // 
            // btn_d_bj
            // 
            this.btn_d_bj.AutoSize = true;
            this.btn_d_bj.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_d_bj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_d_bj.Location = new System.Drawing.Point(6, 28);
            this.btn_d_bj.Name = "btn_d_bj";
            this.btn_d_bj.Size = new System.Drawing.Size(92, 25);
            this.btn_d_bj.TabIndex = 12;
            this.btn_d_bj.Text = "编辑模式";
            this.btn_d_bj.UseVisualStyleBackColor = true;
            this.btn_d_bj.CheckedChanged += new System.EventHandler(this.btn_d_bj_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(336, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "导出全部设备";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "刷新";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "删除";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "添加";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.skinLabel1);
            this.panel2.Controls.Add(this.btn_falsh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 54);
            this.panel2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(486, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MangerDevfrm_Load);
            this.Shown += new System.EventHandler(this.MangerDevfrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DG_List)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_import;
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinButton btn_reload;
        private CCWin.SkinControl.SkinButton btn_plus;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinDataGridView DG_List;
        private CCWin.SkinControl.SkinButton btn_falsh;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btn_d_zd;
        private System.Windows.Forms.RadioButton btn_d_bj;
    }
}