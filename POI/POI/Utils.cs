using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
namespace POI
{
    public class Utils
    {

        public static byte[] clave;
        public static byte[] codigo;
        public static byte[] cleanBuffer(byte[] buffer)
        {
            List<byte> cleanBuffer = new List<byte>();
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] != 0)
                {
                    cleanBuffer.Add(buffer[i]);
                }
            }
            return cleanBuffer.ToArray();
        }
        #region Encriptación
        public static string encriptar(string mensaje)
        {
            clave = Encoding.ASCII.GetBytes("PoIsItHoS");
            codigo = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

            byte[] inputBytes = Encoding.ASCII.GetBytes(mensaje);
            mensaje.Replace('+', ' ');
            byte[] encripted;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(clave, codigo), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }
                encripted = ms.ToArray();
            }
            return Convert.ToBase64String(encripted);
        }

        public static string desencriptar(string mensaje)
        {
            clave = Encoding.ASCII.GetBytes("PoIsItHoS");
            codigo = Encoding.ASCII.GetBytes("Devjoker7.37hAES");
            byte[] inputBytes = Convert.FromBase64String(mensaje);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(clave, codigo), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }
        #endregion

    
    }
}
