using Bandeiras.Models;

namespace Bandeiras
{
    public partial class CountryDetailsForm : Form
    {
        CountryResponse country;

        public CountryDetailsForm(CountryResponse _country)
        {
            InitializeComponent();

            country = _country;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountryDetailsForm_Load(object sender, EventArgs e)
        {
            lblCountryName.Text = country.Name.TranslatedName;

            if (country.Name.Common.Equals("south georgia", StringComparison.InvariantCultureIgnoreCase))
            {
                pcBoxImagem.ImageLocation = "./Images/Map_of_South_Georgia_and_the_South_Sandwich_Islands.png";
            }
            else
            if (country.Name.Common.Equals("dr congo", StringComparison.InvariantCultureIgnoreCase)
                || country.Name.Common.Equals("republic of the congo", StringComparison.InvariantCultureIgnoreCase))
            {
                pcBoxImagem.ImageLocation = "./Images/congo_countries.png";

            }
            else
            {
                MessageBox.Show("Não existem detalhes adicionados para este país.");
                this.Close();
            }
        }

        public void SetCountry(CountryResponse _country)
        {
            country = _country;
        }
    }
}
