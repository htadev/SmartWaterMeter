using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWaterMeter
{
    public partial class MainFrm : Form
    {
        /// <summary>
        /// 图像处理类对象
        /// </summary>
        ImageProcess processor = new ImageProcess();

        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 存储倾斜校正后的定位区域
        /// </summary>
        private Bitmap pic = null;

        //打开文件
        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "位图文件|*.bmp";
            file.ShowDialog();
            string filename = file.FileName;
            Bitmap bmp = new Bitmap(filename);
            pic = (Bitmap)bmp.Clone();
            this.pbImage.Image = bmp;
        }

        //关闭文件
        private void menuCloseFile_Click(object sender, EventArgs e)
        {
            this.pbImage.Image = null;
        }

        //保存
        private void menuSave_Click(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0);
            this.pbImage.Image.Save(@"C:\Users\Administrator\Desktop\" + ts.TotalSeconds + ".bmp");
        }

        //灰度化
        private void menuGraying_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;
                this.pbImage.Image = processor.Graying(bmp);
            }
        }

        //边缘化
        private void menuEdging_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;
                this.pbImage.Image = processor.Edging(bmp);
            }
        }

        //二值化
        private void menuOstu_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;
                this.pbImage.Image = processor.Ostu(bmp);
            }
        }

        //字轮区域定位
        private void menuLocation_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                this.pbImage.Image = processor.CutImage((Bitmap)this.pbImage.Image, 110, 270, 90, 130);
                pic = (Bitmap)this.pbImage.Image.Clone();
            }
        }

        //倾斜矫正
        private void menuJZ_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;

                int theta = processor.Hough(bmp);
                pic = processor.RotateImg(pic, -theta);
                this.pbImage.Image = processor.Ostu((Bitmap)pic.Clone());
            }
        }

        //去除边框
        private void menuCutEdge_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;
                int width = bmp.Width;
                int height = bmp.Height;

                int centerx = width / 2;
                int centery = height / 2;

                int left = centerx - 5, right = centerx + 5;
                int top = centery - 1, buttom = centery + 1;

                int fa = 2;
                int count = 0;
                int lastcount = 0;

                //定位上边界
                do
                {
                    lastcount = count;
                    count = 0;

                    for (int i = top; i < buttom; i++) //height原图高度
                    {
                        for (int j = left; j < right; j++) //width 原图宽度
                        {
                            if (bmp.GetPixel(j, i).R == 255)//统计白色区域的点数
                            {
                                count++;
                            }
                        }
                    }
                    top -= 1;
                } while (count - lastcount > fa);

                lastcount = 0;
                count = 0;

                //定位下边界
                do
                {
                    lastcount = count;
                    count = 0;

                    for (int i = top; i < buttom; i++) //height原图高度
                    {
                        for (int j = left; j < right; j++) //width 原图宽度
                        {
                            if (bmp.GetPixel(j, i).R == 255)
                            {
                                count++;
                            }
                        }
                    }
                    buttom += 1;
                } while (count - lastcount > fa);

                lastcount = 0;
                count = 0;

                //定位左边界
                do
                {
                    lastcount = count;
                    count = 0;

                    for (int i = top; i < buttom; i++) //height原图高度
                    {
                        for (int j = left; j < right; j++) //width 原图宽度
                        {
                            if (bmp.GetPixel(j, i).R == 255)//统计白色区域的点数
                            {
                                count++;
                            }
                        }
                    }
                    left -= 2;
                } while (count - lastcount > fa);
                left += 1;

                lastcount = 0;
                count = 0;

                //定位右边界
                do
                {
                    lastcount = count;
                    count = 0;

                    for (int i = top; i < buttom; i++) //height原图高度
                    {
                        for (int j = left; j < right; j++) //width 原图宽度
                        {
                            if (bmp.GetPixel(j, i).R == 255)
                            {
                                count++;
                            }
                        }
                    }
                    right += 2;
                } while (count - lastcount > fa);
                right += 1;
                this.pbImage.Image = processor.Graying(processor.CutImage(pic, left, right, top, buttom));
            }
        }

        //字符分割(水平等分法)
        private void menuCharactorSegment_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image.Clone();

                int height = bmp.Height;
                int width = bmp.Width;
                int fa = 50;//二值化阀值

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (bmp.GetPixel(i, j).R < fa)
                        {
                            bmp.SetPixel(i, j, Color.Black);
                        }
                        else
                        {
                            bmp.SetPixel(i, j, Color.White);
                        }
                    }
                }
                this.pbImage.Image = bmp;
                int swidth = width / 5;
                int insidewidth = 4;
                Bitmap bmp1 = processor.CutImage(bmp, insidewidth, swidth - insidewidth, 0, height);
                Bitmap bmp2 = processor.CutImage(bmp, swidth + insidewidth, 2 * swidth - insidewidth, 0, height);
                Bitmap bmp3 = processor.CutImage(bmp, 2 * swidth + insidewidth, 3 * swidth- insidewidth, 0, height);
                Bitmap bmp4 = processor.CutImage(bmp, 3 * swidth + insidewidth, 4 * swidth- insidewidth, 0, height);
                Bitmap bmp5 = processor.CutImage(bmp, 4 * swidth + insidewidth, 5 * swidth - insidewidth, 0, height);
                
                this.pb1.Image = bmp1;
                this.pb2.Image = bmp2;
                this.pb3.Image = bmp3;
                this.pb4.Image = bmp4;
                this.pb5.Image = bmp5;
            }
        }

        //字符识别
        private void menuRecongnization_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                Bitmap bmp = (Bitmap)this.pbImage.Image;








                this.pbImage.Image = processor.Graying(bmp);
            }
        }
    }
}
