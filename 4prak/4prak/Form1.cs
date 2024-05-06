using System.Numerics;
using System.Text;


namespace _4prak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void SukurtParasa_Click(object sender, EventArgs e)
        {
            RSA RSAencdec = new();
            byte[] data = RSAencdec.CreateSignatureRSA(Q.Text, P.Text, Tekstas.Text);
            BigInteger SignatureData = new BigInteger(data);
            Parasas.Text = SignatureData.ToString();
            Eksponente.Text = RSAencdec.Eksponente.ToString();
            Modulis.Text = RSAencdec.Modulis.ToString();

            MessageBox.Show("Parasas sukurtas");


        }

        private void TikrintParasa_Click(object sender, EventArgs e)
        {
            RSA rsa = new();

            BigInteger eksponente = BigInteger.Parse(Eksponente.Text);
            BigInteger modulis = BigInteger.Parse(Modulis.Text);
            BigInteger parasas = BigInteger.Parse(Parasas.Text);


            BigInteger signatureCheck = rsa.CheckSignatureRSA(eksponente, modulis, parasas);


            byte[] messageBytes = Encoding.UTF8.GetBytes(Tekstas.Text);


            BigInteger messageBigInt = new BigInteger(messageBytes);


            if (signatureCheck.Equals(messageBigInt))
            {
                MessageBox.Show("Parasa validus");
            }
            else
            {
                MessageBox.Show("Parasas nera validus");
            }
        }

        private void SugeneruotiPirminius_Click(object sender, EventArgs e)
        {

            P.Text = SugeneruotPirminiusSK.GeneratePrimeNumbers(512).ToString();
            Q.Text = SugeneruotPirminiusSK.GeneratePrimeNumbers(512).ToString();

        }
    }
}
