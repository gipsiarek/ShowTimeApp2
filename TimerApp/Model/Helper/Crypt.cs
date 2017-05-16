using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp.Model.Helper
{
    class Crypt
    {
        //private static string _privateKey= "<RSAKeyValue><Modulus>sNisqUkE3886qJOtgTISrIYbd3C+OH0ohU/H59kIEguyAmwje99430InIkobOgzdupZREfV7ht6AMe2lMrdYk1pabmiNuQkLLT34Ls0cIb15NLegBOhvzHDh7RI2nK7HykwEnbxa1xTxUEvqaWgH9sO3sgSUrmsikGB6IsdJj/s=</Modulus><Exponent>AQAB</Exponent><P>3PAyvPynYs+r7wRMz0aEifMbGsmRfZD1GYbQuq1jM0e6b6rBEZNI4h9JJVTvNjWbFvrtGlbf28dK8KsstL1Stw==</P><Q>zOk02YGAuyy1XSwj7fRyi8LRyY3Q1z6qFO4eZN07mMWqfQ+kLwIGO62DtJ6buOly3fnqEGQih+xjiwBjCKgY3Q==</Q><DP>mQaFHgCgrv/HxjTkPmxJQILxMwyJiL7uBFAsIiAVpV748n8CWnn48SVaNFEvngxi7ve9YZDqW/8dGLR2sniu4Q==</DP><DQ>FXIW2OjH208bkCvNetsJnfz+zdRs1go17MjbH31T/nI5nKslaNISau6HCUFMVPcB0Z+VUq/YOVeRN3wL4V0OdQ==</DQ><InverseQ>ZIw6PMQUaQB3slUPYjHXvp3lS+H+eQLqNv8iQqfWecZyi9r9PQrrlXbU+BKKDde3Lpt7dp1Af6mQLgVJaNGlDQ==</InverseQ><D>PN+ot3DiE6RCncqPu9wfn3FePQP7BnjWnOT0e/MyGvwZn0nYAQjQk5Ey5VO7AYVyQYsChvsINUmbuRQDfGyuOSAXmeBu6URwSHWGev7+U++BgdTRuNy2Ez49REDnQTJtVP2zD7RTL1U8JV7ySmw2SAT7/9djXRsF6Q4YqXaLKJk=</D></RSAKeyValue>";
        //private static string _publicKey= "<RSAKeyValue><Modulus>sNisqUkE3886qJOtgTISrIYbd3C+OH0ohU/H59kIEguyAmwje99430InIkobOgzdupZREfV7ht6AMe2lMrdYk1pabmiNuQkLLT34Ls0cIb15NLegBOhvzHDh7RI2nK7HykwEnbxa1xTxUEvqaWgH9sO3sgSUrmsikGB6IsdJj/s=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        //private static UTF8Encoding _encoder = new UTF8Encoding();

        //public static string Decrypt(string data)
        //{
        //    var rsa = new RSACryptoServiceProvider();
        //    var dataArray = data.Split(new char[] { ',' });
        //    byte[] dataByte = new byte[dataArray.Length];
        //    for (int i = 0; i < dataArray.Length; i++)
        //    {
        //        dataByte[i] = Convert.ToByte(dataArray[i]);
        //    }

        //    rsa.FromXmlString(_privateKey);
        //    var decryptedByte = rsa.Decrypt(dataByte, false);
        //    return _encoder.GetString(decryptedByte);
        //}

        //public static string Encrypt(string data)
        //{
        //    var rsa = new RSACryptoServiceProvider();
        //    rsa.FromXmlString(_privateKey);
        //    var dataToEncrypt = _encoder.GetBytes(data);
        //    var encryptedByteArray = rsa.Encrypt(dataToEncrypt, false).ToArray();
        //    var length = encryptedByteArray.Count();
        //    var item = 0;
        //    var sb = new StringBuilder();
        //    foreach (var x in encryptedByteArray)
        //    {
        //        item++;
        //        sb.Append(x);

        //        if (item < length)
        //            sb.Append(",");
        //    }

        //    return sb.ToString();
        //}


    }
}