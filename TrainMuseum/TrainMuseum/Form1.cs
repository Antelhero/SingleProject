﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TrainMuseum.Service;
using TrainMuseum.DAC;
using System.IO;

namespace TrainMuseum
{
    public partial class Form1 : Form
    {
        DataTable dtAll;
        DataTable dtAll2;
        LoadData ld = new LoadData();
        MemberDAC Memdac = new MemberDAC();
        TrainmuseumService ts = new TrainmuseumService();
        UploadMuseumDAC Musdac = new UploadMuseumDAC();
        public Form1()
        {
            InitializeComponent();
        }

        private bool isMuseum = true;
        private void button1_Click(object sender, EventArgs e)
        {
            isMuseum = true;
            trvMenu.Nodes.Clear();
            listView1.Items.Clear();
            MuseumPictureView(dtAll, listView1);

            btnInsertBoard.Visible = false;
            if (Memdac.IsManager(lblmember.Text) == true)
            {
                btnInsertMuseum.Visible = true;
            }
            else
            {
                btnInsertMuseum.Visible = false;
            }
            DataTable dt = ld.InfoLoadData();
            MuseumTreeView(dt);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            isMuseum = false;
            trvMenu.Nodes.Clear();
            listView1.Items.Clear();
            dtAll2 = ts.BoardSelectAll();
            BoardPictureView(dtAll2, listView1);
            btnInsertMuseum.Visible = false;

            if (Memdac.IsMember(lblmember.Text) == true)
            {
                btnInsertBoard.Visible = true;
            }
            else
            {
                btnInsertBoard.Visible = false;
            }
            DataTable dt = ld.InfoLoadData();
            BoardTreeView(dt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberDAC Memdac = new MemberDAC();
            Login frm2 = new Login();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                if (GlobalClass.userid == "")
                {
                    btnLogin.Visible = true;
                    btnLogout.Visible = false;
                    lblWelcome.Visible = false;
                }
                else
                {
                    lblmember.Text = GlobalClass.userid;
                    btnLogout.Visible = true;
                    btnLogin.Visible = false;
                    lblWelcome.Visible = true;
                    if (Memdac.IsManager(GlobalClass.userid) == true)
                    {
                        btnInsertMuseum.Visible = true;
                    }
                    if (Memdac.IsMember(GlobalClass.userid) == true)
                    {
                        btnInsertBoard.Visible = true;
                    }
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (lblWelcome.Visible == true)
            {
                MessageBox.Show("로그아웃 되었습니다.");
                lblWelcome.Visible = false;
                lblmember.Text = "로그인 해 주십시오.";
                btnLogout.Visible = false;
                btnLogin.Visible = true;
                GlobalClass.userid = "";
            }
            btnInsertMuseum.Visible = false;
            btnInsertBoard.Visible = false;
        }
        private void btnInsertMuseum_Click(object sender, EventArgs e)
        {
            MuseumInsUpForm frm1 = new MuseumInsUpForm();
            frm1.Show();
        }

        private void btnInsertBoard_Click(object sender, EventArgs e)
        {
            BoardInsUpForm frm = new BoardInsUpForm();
            frm.Show();
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말로 프로그램을 종료하십니까?", "나가기 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = ld.InfoLoadData();
            MuseumTreeView(dt);
            dtAll = ts.SelectAll();
            dtAll2 = ts.BoardSelectAll();
            MuseumPictureView(dtAll, listView1);
        }

        private void MuseumTreeView(DataTable dt)
        {
            DataRow[] drArr = dt.Select("category = 'carType'");
            foreach (DataRow dr in drArr)
            {
                TreeNode fstNode = new TreeNode();
                fstNode.Text = dr["name"].ToString();
                fstNode.Tag = dr["codeNo"].ToString();

                DataRow[] drArr2 = dt.Select("category = 'status'");
                foreach (DataRow dr2 in drArr2)
                {
                    TreeNode scdNode = new TreeNode();
                    scdNode.Text = dr2["name"].ToString();
                    scdNode.Tag = dr["codeNo"].ToString() + "@" + dr2["codeNo"].ToString();
                    fstNode.Nodes.Add(scdNode);

                    if (dr["codeNo"].ToString() != "103")
                    {
                        DataRow[] drArr3 = dt.Select("category = 'fuelType'");
                        foreach (DataRow dr3 in drArr3)
                        {
                            TreeNode trdNode = new TreeNode();
                            trdNode.Text = dr3["name"].ToString();
                            trdNode.Tag = dr["codeNo"].ToString() + "@" + dr2["codeNo"].ToString() + "@" + dr3["codeNo"].ToString();
                            scdNode.Nodes.Add(trdNode);

                            if (dr["codeNo"].ToString() == "102" && dr3["codeNo"].ToString() == "302")
                            {
                                DataRow[] drArr4 = dt.Select("category = 'carSize'");
                                foreach (DataRow dr4 in drArr4)
                                {
                                    TreeNode fthNode = new TreeNode();
                                    fthNode.Text = dr4["name"].ToString();
                                    fthNode.Tag = dr["codeNo"].ToString() + "@" + dr2["codeNo"].ToString() + "@" + dr3["codeNo"].ToString() + "@" + dr4["codeNo"].ToString();

                                    trdNode.Nodes.Add(fthNode);
                                }
                            }
                        }
                    }
                }
                trvMenu.Nodes.Add(fstNode);
            }
        }
        private void BoardTreeView(DataTable dt)
        {
            DataRow[] drArr5 = dt.Select("category='boardType'");
            foreach (DataRow dr5 in drArr5)
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = dr5["name"].ToString();
                rootNode.Tag = dr5["codeNo"].ToString();

                trvMenu.Nodes.Add(rootNode);
            }
        }
        private void MuseumPictureView(DataTable dt, ListView lvw)
        {
            lvw.Clear();

            // 테이블 Row가 없을때
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string key = string.Format("{0}@{1}@{2}@{3}@{4}", dr["carType"], dr["status"], dr["fuelType"], dr["carSize"], dr["museumTitle"]);
                    imageList1.Images.Add(key, Image.FromFile(Application.StartupPath + "\\" + dr["photoFile1"].ToString()));

                    lvw.Items.Add(new ListViewItem(dr["museumTitle"].ToString(), key));
                }
            }
        }
        private void BoardPictureView(DataTable dt, ListView lvw)
        {
            lvw.Clear();

            // 테이블 Row가 없을때
            if (dt.Rows.Count > 0)
            {
                //사진없을때
                string picture = "boardPhoto/글올리기 테스트/201911071803151.png";
                foreach (DataRow dr in dt.Rows)
                {
                    string key = string.Format("{0}@{1}", dr["boardType"], dr["boardTitle"]);
                    imageList1.Images.Add(key, Image.FromFile(Application.StartupPath + "\\" +
                        (dr["photoFile1"].ToString() != "" ? dr["photoFile1"].ToString() : picture)
                        ));

                    lvw.Items.Add(new ListViewItem(dr["boardTitle"].ToString(), key));
                }
            }
        }
        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

            string[] strArr = e.Node.Tag.ToString().Split('@');

            DataView dv = new DataView(dtAll);
            DataView dv2 = new DataView(dtAll2);


            if (strArr.Length == 1)
            {
                if (e.Node.Text == "자유 게시판" || e.Node.Text == "문의 게시판")
                {
                    dv2.RowFilter = string.Format("boardType = '{0}' ", strArr[0]);
                    BoardPictureView(dv2.ToTable(), listView1);
                }
                else
                {
                    dv.RowFilter = string.Format("carType='{0}' ", strArr[0]);
                    MuseumPictureView(dv.ToTable(), listView1);
                }
            }
            else if (strArr.Length == 2)
            {
                dv.RowFilter = string.Format("carType='{0}' and status='{1}' ", strArr[0], strArr[1]);
                MuseumPictureView(dv.ToTable(), listView1);
            }
            else if (strArr.Length == 3)
            {
                dv.RowFilter = string.Format("carType='{0}' and status='{1}' and fuelType='{2}'", strArr[0], strArr[1], strArr[2]);
                MuseumPictureView(dv.ToTable(), listView1);
            }
            else if (strArr.Length == 4)
            {
                dv.RowFilter = string.Format("carType='{0}' and status='{1}' and fuelType='{2}' and carSize='{3}'", strArr[0], strArr[1], strArr[2], strArr[3]);
                MuseumPictureView(dv.ToTable(), listView1);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (isMuseum)
                {
                    //  int test = ((ListView)sender).Items.Count;
                    GlobalClass.museumtitle = listView1.SelectedItems[0].Text;

                    MuseumShow frm = new MuseumShow();
                    frm.Show();
                }
                else
                {
                    // 자유게시판 인거 확인하고
                    //  if (trvMenu.SelectedNode.Text == "자유 게시판" || trvMenu.SelectedNode.Text == "문의 게시판")
                    GlobalClass.boardtitle = listView1.SelectedItems[0].Text;
                    BoardShow frm2 = new BoardShow();
                    frm2.Show();
                }
            }
            catch
            {
                MessageBox.Show("아직 구현의 한계로 반드시 트리뷰를 클릭해주셔야 합니다.");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isMuseum)
            {

                listView1.Items.Clear();
                MuseumPictureView(dtAll, listView1);
            }
            else
            {
                listView1.Items.Clear();
                dtAll2 = ts.BoardSelectAll();
                BoardPictureView(dtAll2, listView1);
            }
        }
    }
}
