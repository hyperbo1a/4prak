using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4prak
{
    internal class RSA
    {
        // Viešieji savybių deklaravimai
        public BigInteger Eksponente { get; set; } // Viešasis eksponentas
        public BigInteger Modulis { get; set; } // Modulis
        public BigInteger PrivateKey { get; set; } // Privatus raktas

        // Konstruktorius
        public RSA()
        {
        }

        // Metodas, kuris sukūrė RSA parašą
        public byte[] CreateSignatureRSA(string X, string Y, string Input)
        {
            // Konvertuojami įvesties duomenys į BigInteger
            BigInteger p = BigInteger.Parse(X);
            BigInteger q = BigInteger.Parse(Y);

            // Skaičiuojamas modulis ir phi funkcija
            BigInteger n = N(p, q);
            BigInteger phi = Phi(p, q);

            // Generuojamas viešasis eksponentas ir privatus raktas
            BigInteger e = genE(phi);
            BigInteger d = genD(e, phi);

            // Nustatomos viešosios savybės
            Eksponente = e;
            Modulis = n;
            PrivateKey = d;

            // Konvertuojami įvesties duomenys į baitų masyvą
            byte[] inputBytes = Encoding.UTF8.GetBytes(Input);
            BigInteger inputBigInteger = new BigInteger(inputBytes);

            // Sugeneruojamas parašas
            return GenerateSignature(inputBigInteger, d, n).ToByteArray();
        }

        // Metodas, skirtas patikrinti RSA parašą
        public BigInteger CheckSignatureRSA(BigInteger e, BigInteger n, BigInteger signature)
        {
            return BigInteger.ModPow(signature, e, n);
        }

        // Statinis metodas, kuris konvertuoja eilutę į BigInteger
        public static BigInteger StringToBigInteger(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return new BigInteger(bytes);
        }

        // Statinis metodas, kuris konvertuoja BigInteger į eilutę
        public static string BigIntegerToString(BigInteger bigInteger)
        {
            byte[] bytes = bigInteger.ToByteArray();
            return Encoding.UTF8.GetString(bytes);
        }

        // Metodas, kuris tikrina, ar skaičius yra pirminis
        public static bool IsPrime(BigInteger n)
        {
            int k = 10;
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                BigInteger a = 0;
                do
                {
                    byte[] bytes = new byte[n.ToByteArray().Length];
                    random.NextBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1)
                    continue;

                for (int j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        // Metodas, kuris sugeneruoja privačią D reikšmę
        private static BigInteger genD(BigInteger e, BigInteger phi)
        {
            BigInteger d = extendedEuclid(e, phi);
            return d;
        }

        // Metodas, kuris vykdo išplėstinį Euklido algoritmą
        private static BigInteger extendedEuclid(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        // Metodas, kuris apskaičiuoja modulį N
        private BigInteger N(BigInteger p, BigInteger q)
        {
            return p * q;
        }

        // Metodas, kuris apskaičiuoja phi funkciją
        private BigInteger Phi(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        // Metodas, kuris sugeneruoja viešąjį eksponentą E
        private BigInteger genE(BigInteger Phi)
        {
            BigInteger e = 17; // Nustatytas dažniausiai naudojamas viešasis eksponentas
            while (gcd(e, Phi) != 1)
            {
                e++;
            }
            return e;
        }

        // Metodas, kuris apskaičiuoja didžiausią bendrąją daliklių
        private static BigInteger gcd(BigInteger a, BigInteger b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                return gcd(b % a, a);
            }
        }

        // Metodas, kuris sugeneruoja parašą
        private BigInteger GenerateSignature(BigInteger message, BigInteger key, BigInteger n)
        {
            return BigInteger.ModPow(message, key, n);
        }
    }
}
