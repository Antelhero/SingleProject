﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainMuseum.DAC;
using TrainMuseum;

namespace TrainMuseum
{
    public partial class BoardShow : Form
    {
        BoardShowDAC dac = new BoardShowDAC();
        public BoardShow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoardShow_Load(object sender, EventArgs e)
        {
            lblTitle.Text = GlobalClass.boardtitle;

            DataTable dt = dac.SelectBoard(lblTitle.Text);
            DataTable dt2;

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("자료가 없습니다.");
                this.Close();
            }
            else
            {
                dt2 = dac.SelectReply(dt.Rows[0]["boardno"].ToString());
                txtContents.Text = dt.Rows[0]["boardTitle"].ToString();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile1"].ToString();
                // DataView dv = new DataView(dt2);
                // r.userid, r.replyContents
                // dv.RowFilter = "boardno = " 

                dgvReply.ColumnCount = 2;
                dgvReply.Columns[0].Name = "nickname";
                dgvReply.Columns[1].Name = "content";

                for(int i = 0; i < dt2.Rows.Count; i++)
                {
                    string name = dt2.Rows[i]["userid"].ToString();
                    string content = dt2.Rows[i]["replyContents"].ToString();
                    string [] data = { name, content }; 
                    dgvReply.Rows.Add(data);
                }
            }
        }

        private void btnPictureChange_Click(object sender, EventArgs e)
        {
            DataTable dt = dac.SelectBoard(lblTitle.Text);

            for(int i = 1; i < 6; i++)
            {
                if (dt.Rows[0]["photoFile" + i.ToString()].ToString() == pictureBox1.ImageLocation)
                {
                    pictureBox1.Refresh();
                    pictureBox1.ImageLocation = dt.Rows[0]["photoFile" + ((i % 5) + 1).ToString()].ToString();
                    break;
                }
            }
            /*
            if (dt.Rows[0]["photoFile1"].ToString() == pictureBox1.ImageLocation)
            {
                pictureBox1.Refresh();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile2"].ToString();

            }
            else if (dt.Rows[0]["photoFile2"].ToString() == pictureBox1.ImageLocation)
            {
                pictureBox1.Refresh();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile3"].ToString();
            }
            else if (dt.Rows[0]["photoFile3"].ToString() == pictureBox1.ImageLocation)
            {
                pictureBox1.Refresh();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile4"].ToString();
            }
            else if (dt.Rows[0]["photoFile4"].ToString() == pictureBox1.ImageLocation)
            {
                pictureBox1.Refresh();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile5"].ToString();
            }
            else
            {
                pictureBox1.Refresh();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile1"].ToString();
            }
            */
        }
    }
}
