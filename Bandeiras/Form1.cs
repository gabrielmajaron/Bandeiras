using Bandeiras.Handlers;
using Bandeiras.Models;
using System.Diagnostics;

namespace Bandeiras
{
    public partial class Form1 : Form
    {
        List<CountryResponse> allCountries;
        List<CountryResponse> filteredCountries;
        List<CountryResponse> wrongAnsweredCountries;

        CountryDetailsForm? countryDetailsForm = null;

        int pointer = 0;

        public Form1()
        {
            InitializeComponent();
            this.picBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            wrongAnsweredCountries = new List<CountryResponse>();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (filteredCountries.Count == 0)
            {
                picBoxFlag.Image = null;
                lblNomeBandeira.Text = "";
                return;
            }

            if (ckbRandom.Checked)
                pointer = new Random().Next(0, filteredCountries.Count);
            else
                pointer = pointer + 1 >= filteredCountries.Count ? 0 : pointer + 1;

            picBoxFlag.Image = ByteToImage(filteredCountries.ElementAt(pointer).Flags.PngBytes);
            lblNomeBandeira.Text = filteredCountries.ElementAt(pointer).Name.TranslatedName;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblNomeBandeira.Visible = !checkBox1.Checked;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (filteredCountries.Count == 0)
            {
                picBoxFlag.ImageLocation = "";
                lblNomeBandeira.Text = "";
                return;
            }

            if (ckbRandom.Checked)
                pointer = new Random().Next(0, filteredCountries.Count);
            else
                pointer = pointer - 1 <= -1 ? filteredCountries.Count - 1 : pointer - 1;


            picBoxFlag.Image = ByteToImage(filteredCountries.ElementAt(pointer).Flags.PngBytes);

            lblNomeBandeira.Text = filteredCountries.ElementAt(pointer).Name.TranslatedName;
        }

        private async Task LoadData()
        {
            CountryHandler c = new CountryHandler(this);
            FileHandler f = new FileHandler();

            try
            {
                SetLoadingState();

                allCountries = f.LoadCountries();

                if (allCountries == null)
                {
                    lblLoading.Text = "";
                    allCountries = await c.GetCountries();
                    f.SaveCountries(allCountries);
                }

                filteredCountries = CloneCountries(allCountries);

                SetCbbCountriesNames(allCountries);
                SetCbbContinentsNames(allCountries);
                SetReadyState();
            }
            catch (Exception ex)
            {
                f.RemoveFile();
                MessageBox.Show($"Erro: {ex.Message}.{Environment.NewLine}Verifique a sua conexão com a internet.");
                lblLoading.Text = "Erro: Conecte na internet e reinicie o programa.";
            }
        }

        private List<CountryResponse> CloneCountries(List<CountryResponse> countries)
        {
            List<CountryResponse> clone = new List<CountryResponse>();

            foreach (var country in countries)
                clone.Add((CountryResponse)country.Clone());

            return clone;
        }

        private void SetCbbContinentsNames(List<CountryResponse> countries)
        {
            var continentGroup = countries.GroupBy(c => c.Continents);

            List<string> items = new List<string> { "All" };
            foreach (var continent in continentGroup)
            {
                var continentNames = continent.Key;
                items.AddRange(continentNames);

            }
            items = items.Distinct().ToList();
            cbbContinents.Items.AddRange(items.ToArray());
            cbbContinents.SelectedIndex = 0;
        }

        private void SetCbbCountriesNames(List<CountryResponse> countries)
        {
            cbbAnswer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbAnswer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection aCompl = new AutoCompleteStringCollection();
            var data = countries.Select(c => c.Name.TranslatedName).ToArray();
            aCompl.AddRange(data);
            cbbAnswer.DataSource = null;
            cbbAnswer.Items.Clear();
            cbbAnswer.DataSource = data;
            cbbAnswer.AutoCompleteCustomSource = aCompl;
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SetLoadingState()
        {
            cbbAnswer.Enabled = false;
            lblLoading.Visible = true;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            lblCountriesRemaining.Text = "0";
        }

        private void SetReadyState()
        {
            cbbAnswer.Enabled = true;
            lblLoading.Visible = false;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;

            pointer = 0;
            picBoxFlag.Image = ByteToImage(filteredCountries.First().Flags.PngBytes);
            lblNomeBandeira.Text = filteredCountries.First().Name.TranslatedName;
            lblCountriesRemaining.Text = filteredCountries.Count.ToString();
            cbbAnswer.Text = "";
            wrongAnsweredCountries = new List<CountryResponse>();
        }

        private void cbbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                checkBox1.Checked = !checkBox1.Checked;
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (cbbAnswer.Text == "")
                {
                    btnNext_Click(null, null);
                    return;
                }

                if (filteredCountries.Count == 0)
                    return;

                var questionCountry = filteredCountries.ElementAt(pointer);

                if (cbbAnswer.Text == questionCountry.Name.TranslatedName)
                {
                    lblCountriesRemaining.Text = (Convert.ToInt32(lblCountriesRemaining.Text) - 1).ToString();
                    filteredCountries.Remove(questionCountry);
                    pointer--;
                    btnNext_Click(null, null);
                }
                else
                {
                    if (!wrongAnsweredCountries.Contains(questionCountry))
                        wrongAnsweredCountries.Add(questionCountry);
                }
            }
        }

        private void cbbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbContinents.SelectedIndex == 0)
            {
                filteredCountries = CloneCountries(allCountries);
                SetCbbCountriesNames(filteredCountries);
                SetReadyState();
                return;
            }

            var continent = cbbContinents.SelectedItem.ToString();

            if (continent == null)
            {
                MessageBox.Show("Erro ao tentar obter continente para o filtro");
                return;
            }

            filteredCountries = allCountries.Where(c => c.Continents.Contains(continent)).ToList();

            SetCbbCountriesNames(filteredCountries);
            SetReadyState();
        }


        private delegate void CallbackUpdateTxtProgress(string text);

        public void UpdateTxtProgress(string text)
        {
            if (InvokeRequired)
            {
                lblLoading.BeginInvoke(new CallbackUpdateTxtProgress(UpdateTxtProgress), new object[] { text });
            }
            else
            {
                lblLoading.Text = text;
                lblLoading.Refresh();
            }
        }

        private void lblNomeBandeira_Click(object sender, EventArgs e)
        {
            var currentCountry = filteredCountries.ElementAt(pointer);

            if (ImageDetailsExists(currentCountry.Name.Common))
            {
                if (countryDetailsForm == null)
                    countryDetailsForm = new CountryDetailsForm(currentCountry);
                else
                    countryDetailsForm.SetCountry(currentCountry);

                countryDetailsForm.ShowDialog();
            }
        }

        private bool ImageDetailsExists(string countryCommonName)
        {
            if (countryCommonName.Equals("south georgia", StringComparison.InvariantCultureIgnoreCase))
                return true;

            if (countryCommonName.Equals("dr congo", StringComparison.InvariantCultureIgnoreCase))
                return true;

            if (countryCommonName.Equals("republic of the congo", StringComparison.InvariantCultureIgnoreCase))
                return true;

            return false;
        }

        private void picBoxBook_Click(object sender, EventArgs e)
        {
            WrongAnswereds form = new WrongAnswereds(wrongAnsweredCountries);
            form.ShowDialog();
        }
    }
}