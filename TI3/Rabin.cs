using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace TI3
{
    public static class Rabin
    {

        private static readonly int buf = 4096;
        private static long FastExp(long a, long z, long n) //алгоритм быстрого возведения в степень
        {  
            var a1 = a;
            var z1 = z;
            long x = 1;
           
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 >>= 1; // div 2
                    a1 = (a1 * a1) % n;
                }
                --z1;
                x = (x * a1) % n;
            }
            return x;
        }

        private static long extEuclid(ref long a,ref long b)
        {  
            var d0 = a;
            var d1 = b;
            long x0 = 1;
            long x1 = 0;
            long y0 = 0;
            long y1 = 1;
            while (d1>1)
            {
                var q = d0 / d1;
                var d2 = d0 % d1;
                var x2 = x0 - q * x1;
                var y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            a = x1;
            b = y1;
            return d1;
        }

        private static bool millerTest(long d, long n)
        {

            
            Random r = new Random();
            long a = r.Next(2, (int)n - 1);

            long x = FastExp(a, d, n);

            if (x == 1 || x == n - 1)
                return true;


            while (d != n - 1)
            {
                x = (x * x) % n;
                d <<= 1;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }

            return false;
        }
        private static bool isPrime(long n, long k=10)
        {

            
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            long d = n - 1;

            while (d % 2 == 0)
                d >>=1;

            for (int i = 0; i < k; i++)
                if (millerTest(d, n) == false)
                    return false;

            return true;
        }


        private static bool compareByModulo(long a, long b)
        {
            return ((a % 4 == 3) && (b % 4 == 3));
        }

        private static bool isUniqueness(long P, long Q, long B) //условие однозначности
        {
            return ((B>=0 && B<10533)&& ((P >=3 && Q >=523) || (Q >=3 && P >=523))); 
        }


       private static int countBytes(long value) //подсчет количества байтов, требуемых для записи шифротекста (зависит от N)
        {
            int len = 0;
            while (value!=0)
            {
                value >>=8;
                ++len;
            }
            return len;
        }
        
        private static long CheckExceptions(long P, long Q, long N,string b)
        {
            if (!(isPrime(P) && isPrime(Q)))
                throw new Exception("Числа не являются простыми");
            if (!compareByModulo(P, Q))
                throw new Exception("Числа P,Q не являются сравнимыми по модулю 4");
            
            long B = 0;
            B = long.Parse(b);
            
           

            if (B >= N)
                throw new Exception("Число B не меньше P*Q");
            if (!(B<Int32.MaxValue && P < Int32.MaxValue && Q < Int32.MaxValue && B>=0 && Q>0 && P>0))
                throw new Exception("Введенные параметры выходят за диапазон ["+1+".."+Int32.MaxValue+")");
            return B;                      
        }
        private static string newPath(string pathToFile,StringBuilder ext)
        {
            
            int i = pathToFile.Length - 1;
            while (pathToFile[i]!='.' && i>0)
            {
                --i;
            }
            string newFile = pathToFile.Substring(0, i + 1) + ext;
            ext.Remove(0, ext.Length);
            ext.Append(pathToFile.Substring(i + 1, pathToFile.Length - i - 1));            
            return newFile;
        }
        public static void Encrypt(string p, string q, string b, string pathToFile, TextBox[] TBox)
        {
            long P = long.Parse(p);
            long Q = long.Parse(q);
            long N = P * Q;
            long B = CheckExceptions(P, Q, N, b);
           
            TBox[2].Text = N.ToString();
            int len = countBytes(N);//определяем число байт для записи шифротекста
          
            FileStream inFStream = new FileStream(pathToFile, FileMode.Open);
            StringBuilder ext = new StringBuilder("rbn");
            FileStream writeFStream = new FileStream(newPath(pathToFile,ext), FileMode.Create);
            byte[] arrRead = new byte[buf*len];
            writeFStream.WriteByte((byte)ext.Length);
            writeFStream.Write(Encoding.Default.GetBytes(ext.ToString()), 0, ext.Length);//расширение файла 
            List<byte> arrW = new List<byte>();
            long Cipher = 0;
            int count = 0;
            string toTextBox = "";
            string toSourceBox = "";
            while ((count = inFStream.Read(arrRead, 0, buf*len)) != 0) //пока не конец файла
            {    
               
                for (int i = 0; i < count; i++)
                {
                    Cipher = (arrRead[i] * (arrRead[i] + B)) % N; //C=M(M+B) mod N 
                    var arr = BitConverter.GetBytes(Cipher);
                    for (int j=0;j<len;j++)
                    {
                        arrW.Add(arr[j]);
                    }
                    
                    toTextBox += Cipher.ToString()+ ' ';
                    toSourceBox += arrRead[i].ToString()+' ';
                }
                TBox[1].Text += toSourceBox;
               writeFStream.Write(arrW.ToArray(), 0,arrW.Count);
                TBox[0].Text += toTextBox;
                toTextBox = "";
                toSourceBox = "";
                arrW.Clear();
            }
            writeFStream.Close();
            inFStream.Close();

        }
        private static long[] CalculateManyFormulas(long B, long N, long P, long Q, long Yp, long Yq, byte[] masCipher,StringBuilder sourceStr )
        {
            List<byte> list = new List<byte>();
            list.AddRange(masCipher);
            while (list.Count!=8)
            {
                list.Add(0);
            }
            long Cipher = BitConverter.ToInt64(list.ToArray(), 0);
            sourceStr.Append(Cipher.ToString() + ' ');
            long D = (B * B + 4 * Cipher) % N;

            long Mp = FastExp(D, (P + 1) >> 2, P);
            long Mq = FastExp(D, (Q + 1) >> 2, Q);
           
            long[] arrD = new long[4];
            long mul1 = Yp * P * Mq;
            long mul2 = Yq * Q * Mp;
            arrD[0] = (mul1 + mul2) % N; 
            arrD[1] = N - arrD[0];
            arrD[2] = (mul1 - mul2) % N; 
            arrD[3] = N - arrD[2]; 
            return arrD;
        }
       //однозначная расшифровка
        private static void DecryptUniqueness(string pathToFile,int len,long B,long N, long P, long Q, long Yp, long Yq, TextBox[] TBox)
        {
            FileStream inFStream = new FileStream(pathToFile, FileMode.Open);
            StringBuilder ext = new StringBuilder();
            pathToFile = newPath(pathToFile, ext);
            int extlen=inFStream.ReadByte();
            byte[] arrExt = new byte[extlen];
            inFStream.Read(arrExt, 0, extlen);
            ext.Remove(0, ext.Length);
            ext.Append(Encoding.Default.GetString(arrExt));
            FileStream writeFStream = new FileStream(pathToFile+ext.ToString(), FileMode.Create);
            byte[] arrRead = new byte[buf*len]; //буфер кратен длине шифротекста
            List<byte> arrW = new List<byte>();
            
            int count = 0;
            string toTextBox = "";
            byte[] masCipher = new byte[len];
            StringBuilder toSourceBox = new StringBuilder("");
            while ((count = inFStream.Read(arrRead, 0, buf*len)) != 0) 
            {
                for (int i = 0; i < count / len; i++)
                {
                    
                    Array.Copy(arrRead, i * len, masCipher, 0,len);
                    long[] arrD =CalculateManyFormulas(B, N, P, Q,Yp,Yq, masCipher,toSourceBox);
                   
                   

                    for (int j = 0; j < 4; j++)
                    {   
                            var res = arrD[j] - B;
                            arrD[j] = ((res) % 2 == 0) ? ((res) >> 1) % N : (((res) + N) >> 1) % N;           
                        if (arrD[j] <=255 && arrD[j]>=0) //если М лежит в диапазоне байта, то это искомое значение
                        {
                            toTextBox += arrD[j].ToString() + ' ';         
                            arrW.Add((byte)arrD[j]);
                            break;
                        }
                       
                    }
                }
                writeFStream.Write(arrW.ToArray(), 0, arrW.Count);
                TBox[1].Text += toSourceBox;
                TBox[0].Text += toTextBox;
                toSourceBox.Clear();               
                toTextBox = "";
                arrW.Clear();
            }
            writeFStream.Close();
            inFStream.Close();
        }


        //при неоднозначности расшифрованный файл не создается, на экран выводятся 4 возможных варианта исходного текста
        private static void DecryptAmbiguity(string pathToFile, int len,long B, long N, long P, long Q, long Yp, long Yq, TextBox[] TBox)
        {
            FileStream inFStream = new FileStream(pathToFile, FileMode.Open);
            byte[] arrRead = new byte[buf * len]; //буфер кратен длине шифротекста
            int extlen = inFStream.ReadByte();
            byte[] arrExt = new byte[extlen];
            inFStream.Read(arrExt, 0, extlen);
            int count = 0;
            string toTextBox = "";
            byte[] masCipher = new byte[len];
            StringBuilder toSourceBox = new StringBuilder("");
            while ((count = inFStream.Read(arrRead, 0, buf*len)) != 0) 
            {
                
                for (int i = 0; i < count / len; i++)
                {
                    
                    Array.Copy(arrRead, i * len, masCipher, 0, len);
                    long[] arrD = CalculateManyFormulas(B, N, P, Q,Yp,Yq, masCipher,toSourceBox);
                   
                    for (int j = 0; j < 4; j++)
                    {                       
                            var res = arrD[j] - B;
                            arrD[j] = ((res) % 2 == 0) ? ((res) >> 1) % N : (((res) + N) >> 1) % N;     
                            toTextBox += arrD[j].ToString() + ' ';                        
                    }
                    toTextBox += Environment.NewLine;
                }
                            
                TBox[0].Text +=toTextBox;
                TBox[1].Text += toSourceBox;
                toSourceBox.Clear();
                toTextBox = "";
            }
            
            inFStream.Close();
        }




        public static void Decrypt(string p, string q, string b, string pathToFile, TextBox[] TBox)
        {
            long P = long.Parse(p); //перевод из строки в число
            long Q = long.Parse(q);
            
            
            long N = P * Q;
            
            long B = CheckExceptions(P, Q, N, b);
            TBox[2].Text = N.ToString();
            int len = countBytes(N);
            long Yp = P;
            long Yq = Q;
            
            extEuclid(ref Yp, ref Yq);
        
            if (isUniqueness(P,Q,B)) //если однозначность
            {
                DecryptUniqueness(pathToFile,len, B, N, P, Q, Yp, Yq, TBox);
            }
            else
            {
                DecryptAmbiguity(pathToFile, len,B, N, P, Q, Yp, Yq, TBox);
                MessageBox.Show("Неоднозначная ситуация", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    
        }
    }
}
