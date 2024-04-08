using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace _2prak
{
    public partial class Form1 : Form
    {
        private BigInteger[] encryptedText; // Saugoti užšifruotą tekstą

        public Form1()
        {
            InitializeComponent();
        }

        private void sifruoti_Click(object sender, EventArgs e)
        {
            BigInteger p;
            if (!BigInteger.TryParse(ivestas_p.Text, out p))
            {
                MessageBox.Show("Įveskite tinkamą skaičių p!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BigInteger q;
            if (!BigInteger.TryParse(ivestas_q.Text, out q))
            {
                MessageBox.Show("Įveskite tinkamą skaičių q!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPrime(p))
            {
                MessageBox.Show("p nėra pirminis skaičius!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPrime(q))
            {
                MessageBox.Show("q nėra pirminis skaičius!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string x = ivestas_tekstas.Text;

            BigInteger n = p * q;
            BigInteger fi = (p - 1) * (q - 1);

            BigInteger eValue = fE(fi);
            BigInteger d = fD(eValue, fi);

            encryptedText = Encrypt(x, n, eValue); // Užšifruotas tekstas saugomas klasės lygyje

            Uzfifruotas_tekstas.Text = string.Join(",", encryptedText);
        }

        private void atsifruot_Click(object sender, EventArgs e)
        {
            if (encryptedText == null)
            {
                MessageBox.Show("Užšifruokite tekstą pirmiau!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BigInteger p;
            if (!BigInteger.TryParse(ivestas_p.Text, out p))
            {
                MessageBox.Show("Įveskite tinkamą skaičių p!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BigInteger q;
            if (!BigInteger.TryParse(ivestas_q.Text, out q))
            {
                MessageBox.Show("Įveskite tinkamą skaičių q!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPrime(p))
            {
                MessageBox.Show("p nėra pirminis skaičius!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPrime(q))
            {
                MessageBox.Show("q nėra pirminis skaičius!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BigInteger n = p * q;
            BigInteger fi = (p - 1) * (q - 1);

            BigInteger eValue = fE(fi);
            BigInteger d = fD(eValue, fi);

            string decrypted = Decrypt(encryptedText, n, d);

            atsifruotas_tekstas.Text = decrypted;
        }

        private BigInteger fE(BigInteger fi)
        {
            for (BigInteger e = 2; e < fi; e++)
            {
                if (BigInteger.GreatestCommonDivisor(e, fi) == 1)
                {
                    return e;
                }
            }
            throw new Exception("Klaida");
        }

        private BigInteger fD(BigInteger e, BigInteger fi)
        {
            BigInteger d = BigInteger.One;

            while ((d * e) % fi != BigInteger.One)
            {
                d++;
            }

            return d;
        }

        private BigInteger[] Encrypt(string text, BigInteger n, BigInteger e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            BigInteger[] encrypted = new BigInteger[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                encrypted[i] = BigInteger.ModPow(bytes[i], (int)e, n);
            }

            return encrypted;
        }

        private string Decrypt(BigInteger[] encrypted, BigInteger n, BigInteger d)
        {
            byte[] decryptedBytes = new byte[encrypted.Length];

            for (int i = 0; i < encrypted.Length; i++)
            {
                decryptedBytes[i] = (byte)BigInteger.ModPow(encrypted[i], (int)d, n);
            }

            return Encoding.Unicode.GetString(decryptedBytes);
        }

        private static bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (BigInteger i = 3; BigInteger.Pow(i, 2) <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}








