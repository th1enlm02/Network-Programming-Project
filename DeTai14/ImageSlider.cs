using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static System.Windows.Forms.ImageList;
using System.Net.Http;
using HtmlAgilityPack;

namespace DeTai14
{
    public partial class ImageSlider : Form
    {
        public ImageSlider()
        {
            InitializeComponent();
        }
        private readonly HttpClient client = new HttpClient();
        int index = 0;
        List<Image> imageCollections = new List<Image>();
        private void bunifuPictureBoxDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            foreach (var img in imageCollections)
            {
                Bitmap bmp = new Bitmap(img);
                if (sfd.ShowDialog() == DialogResult.OK)
                    bmp.Save(sfd.FileName);
            }
        }
        private void bunifuPictureBoxLeft_Click(object sender, EventArgs e)
        {
            --index;
            if (index < 0)
                index = imageCollections.Count - 1;
            pictureBox1.Image = imageCollections[index];
        }
        private void bunifuPictureBoxRight_Click(object sender, EventArgs e)
        {
            ++index;
            if (index == imageCollections.Count)
                index = 0;
            pictureBox1.Image = imageCollections[index];
        }
        private async void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    HtmlWeb web = new HtmlWeb();
                    var htmlDoc = web.Load(textBoxLink.Text);
                    var imgArticles = htmlDoc.DocumentNode?.SelectNodes("//div[@class='box-category-item']//img/@src");
                    foreach (var img in imgArticles)
                    {
                        var imgUrl = img.GetAttributeValue("src", "");
                        var selectedImgStream = await client.GetStreamAsync(imgUrl);
                        Bitmap bmp = new Bitmap(selectedImgStream);
                        Bitmap resizedBmp = ResizeImage(bmp, pictureBox1.Width, pictureBox1.Height);
                        imageCollections.Add(resizedBmp);
                    }
                    pictureBox1.Image = imageCollections[index];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                ImageAttributes wrapMode = new ImageAttributes();
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }
            return destImage;
        }
    }
}
