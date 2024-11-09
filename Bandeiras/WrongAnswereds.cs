using Bandeiras.Common;
using Bandeiras.Models;

namespace Bandeiras
{
    public partial class WrongAnswereds : Form
    {
        int pointer;
        List<CountryResponse> wrongAnswereds;

        public WrongAnswereds(List<CountryResponse> wrongAnswereds)
        {
            InitializeComponent();
            this.wrongAnswereds = wrongAnswereds;
        }

        private void WrongAnswereds_Load(object sender, EventArgs e)
        {
            pointer = 0;
            LoadForm();
        }

        private void LoadForm()
        {
            if (wrongAnswereds.Count == 0)
            {
                try
                {
                    picBoxFlag.SizeMode = PictureBoxSizeMode.Zoom;
                    picBoxFlag.Image = Image.FromFile(Constants.flagsImgRelativePath);
                }
                catch { }

                lblFlagName.Text = "";
                lblFlagsCount.Text = "0";
                pointer = 0;

                return;
            }


            picBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            var flag = wrongAnswereds.ElementAt(pointer);
            picBoxFlag.Image = ByteToImage(flag.Flags.PngBytes);
            lblFlagName.Text = flag.Name.TranslatedName;
            lblFlagsCount.Text = wrongAnswereds.Count.ToString();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (wrongAnswereds.Count == 0)
                return;

            wrongAnswereds.RemoveAt(pointer);
            WrongAnswereds_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wrongAnswereds.Clear();
            WrongAnswereds_Load(null, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pointer++;
            if (pointer >= wrongAnswereds.Count)
                pointer = 0;
            LoadForm();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pointer--;
            if (pointer < 0)
                pointer = wrongAnswereds.Count-1;
            LoadForm();
        }
    }
}
