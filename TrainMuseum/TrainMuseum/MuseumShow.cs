using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainMuseum.DAC;
using static TrainMuseum.DAC.MuseumShowDAC;

namespace TrainMuseum
{
    public partial class MuseumShow : Form
    {
        MemberDAC memDAC = new MemberDAC();
        MuseumShowDAC dac = new MuseumShowDAC();
        public MuseumShow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuseumShow_Load(object sender, EventArgs e)
        {
            lblTitle.Text = GlobalClass.museumtitle;
            //m.museumTitle, m.spectation, m.museumContents, p.photofile1, p.photofile2, p.photofile3
            DataTable dt = dac.SelectMuseum(lblTitle.Text);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("자료가 없습니다.");
                this.Close();
            }
            else
            {
                txtSpectation.Text = dt.Rows[0]["spectation"].ToString();
                txtContents.Text = dt.Rows[0]["museumContents"].ToString();
                pictureBox1.ImageLocation = dt.Rows[0]["photoFile1"].ToString();
            }
            if (memDAC.IsManager(GlobalClass.userid) == true)
            {
                btnDelete.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dac.SelectMuseum(lblTitle.Text);

            const int MAX_IMAGE = 3;
            for (int i = 1; i < MAX_IMAGE + 1; i++)
            {
                if (dt.Rows[0][string.Format("photoFile{0}" , i)].ToString() == pictureBox1.ImageLocation)
                {
                    pictureBox1.Refresh();
                    pictureBox1.ImageLocation = dt.Rows[0][string.Format("photoFile{0}", (i % MAX_IMAGE) + 1)].ToString();
                    break;
                }
            }
            /* if (dt.Rows[0]["photoFile1"].ToString() == pictureBox1.ImageLocation)
             {
                 pictureBox1.Refresh();
                 pictureBox1.ImageLocation = dt.Rows[0]["photoFile2"].ToString();

             }
             else if(dt.Rows[0]["photoFile2"].ToString() == pictureBox1.ImageLocation)
             {
                 pictureBox1.Refresh();
                 pictureBox1.ImageLocation = dt.Rows[0]["photoFile3"].ToString();
             }
             else
             {
                 pictureBox1.Refresh();
                 pictureBox1.ImageLocation = dt.Rows[0]["photoFile1"].ToString();
             }
             */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
