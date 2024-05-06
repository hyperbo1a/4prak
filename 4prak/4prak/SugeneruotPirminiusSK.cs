using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4prak
{
    internal class SugeneruotPirminiusSK
    {
        // Nustatytas atsitiktinių skaičių generatorius
        private static Random random = new Random();

        // Metodas, kuris sugeneruoja pirminį skaičių su nurodytu bitų skaičiumi
        public static BigInteger GeneratePrimeNumbers(int bits)
        {
            BigInteger prime;
            // Kartojama, kol sugeneruojamas pirminis skaičius
            do
            {
                prime = GenerateRandomBigInteger(bits);
            } while (!IsPrime(prime));
            return prime;
        }


        // Metodas, kuris sugeneruoja atsitiktinį BigInteger su nurodytu bitų skaičiumi
        private static BigInteger GenerateRandomBigInteger(int bits)
        {
            byte[] bytes = new byte[bits / 8];
            // Generuojami atsitiktiniai baitai
            random.NextBytes(bytes);
            // Paskutinis baitas apribotas, kad nebūtų generuojamas neigiamas skaičius
            bytes[bytes.Length - 1] &= (byte)0x7F;
            return new BigInteger(bytes);
        }

        // Metodas, kuris tikrina, ar skaičius yra pirminis
        private static bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0)
                return false;

            BigInteger d = number - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            // Tikrinama, ar skaičius yra pirminis
            for (int i = 0; i < 10; i++)
            {
                BigInteger a = GenerateRandomBigInteger(512);
                BigInteger x = BigInteger.ModPow(a, d, number);
                if (x == 1 || x == number - 1)
                    continue;
                for (int j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1)
                        return false;
                    if (x == number - 1)
                        break;
                }
                if (x != number - 1)
                    return false;
            }

            return true;
        }
    }
}
