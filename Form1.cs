using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_10_4
{
    public partial class Form1 : Form
    {
        public double CN;
        public double BM;
        public double EN;
        public double MT;
        public double SC;
        public double SJ;
        public double GG;
        public double finalAvScore;
        public double finalScore;
        public string[] type = { "华语", "国文", "英文", "数学", "科学", "历史", "地理","None" };
        public string higherScoreName;

        public Form1()
        {
            InitializeComponent();
        }
        private static void ResultMsg(DialogResult result)
        {
            return;
        }
        private void btnWhat_Click(object sender, EventArgs e)
        {
            String whatMessage = "这是什么？";
            MessageBoxButtons btnWhat = MessageBoxButtons.OK;
            MessageBoxIcon btnWhaticonInfo = MessageBoxIcon.Information;
            DialogResult result;
            result = MessageBox.Show("这是第十章第四题的实作题", whatMessage, btnWhat, btnWhaticonInfo);
            ResultMsg(result);
            MessageBox.Show("题目要求制作一个简易成绩平均计算器");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            String Message1 = "警告";
            MessageBoxButtons btnWarn = MessageBoxButtons.OKCancel;
            MessageBoxIcon iconWarn = MessageBoxIcon.Warning;
            DialogResult result;
            //检测各科是否有写分数
            if (txtCN.Text == "" || txtBM.Text == "" ||  txtEN.Text == "" || txtMT.Text == ""
                || txtSC.Text == "" || txtSJ.Text == "" || txtGG.Text == "")
            {
                result = MessageBox.Show("请写出各科的分数", Message1, btnWarn, iconWarn);
                ResultMsg(result);
                txtBfianlScore.Text = "";
            }
            else
            {
                CN = Convert.ToDouble(txtCN.Text);
                BM = Convert.ToDouble(txtBM.Text);
                EN = Convert.ToDouble(txtEN.Text);
                MT = Convert.ToDouble(txtMT.Text);
                SC = Convert.ToDouble(txtSC.Text);
                SJ = Convert.ToDouble(txtSJ.Text);
                GG = Convert.ToDouble(txtGG.Text);
                finalScore = (CN + BM + EN + MT + SC + SJ + GG);
                finalAvScore = finalScore / 7;
                var All = new List<double> { CN, BM, EN, MT, SC, SJ, GG };
                double finalHigherScore = All.Max();
                txtBfianlScore.Text = "总分：" + finalScore
                    + "\n总平均：" + finalAvScore;
                if (finalHigherScore == CN)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[0] + " " + finalHigherScore;
                }
                else if (finalHigherScore == BM)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[1] + " " + finalHigherScore;
                }
                else if (finalHigherScore == EN)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[2] + " " + finalHigherScore;
                }
                else if (finalHigherScore == MT)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[3] + " " + finalHigherScore;
                }
                else if (finalHigherScore == SC)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[4] + " " + finalHigherScore;
                }
                else if (finalHigherScore == SJ)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[5] + " " + finalHigherScore;
                }
                else if (finalHigherScore == GG)
                {
                    txtBfianlScore.Text += "\n最高分：" + type[6] + " " + finalHigherScore;
                }                
            }   
        }
    }
}
