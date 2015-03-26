using System;
using System.Data;
using System.Security.Cryptography;
using System.IO;

namespace KeyPassBusiness
{
	class CryptoHelper
	{
		/**
		 * code from:
		 * http://www.splinter.com.au/c-cryptography-encrypting-a-bunch-of-bytes/
		 **/
		public static byte[] Encrypt(byte[] input)
		{
			PasswordDeriveBytes pdb = new PasswordDeriveBytes("mykeypass", new byte[] { 0x43, 0x87, 0x23, 0x72 });
			MemoryStream ms = new MemoryStream();
			Aes aes = new AesManaged();
			aes.Key = pdb.GetBytes(aes.KeySize / 8);
			aes.IV = pdb.GetBytes(aes.BlockSize / 8);
			CryptoStream cs = new CryptoStream(ms,
			  aes.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(input, 0, input.Length);
			cs.Close();
			return ms.ToArray();
		}
		public static byte[] Decrypt(byte[] input)
		{
			PasswordDeriveBytes pdb = new PasswordDeriveBytes("mykeypass", new byte[] { 0x43, 0x87, 0x23, 0x72 }); 
			MemoryStream ms = new MemoryStream();
			Aes aes = new AesManaged();
			aes.Key = pdb.GetBytes(aes.KeySize / 8);
			aes.IV = pdb.GetBytes(aes.BlockSize / 8);
			CryptoStream cs = new CryptoStream(ms,
			  aes.CreateDecryptor(), CryptoStreamMode.Write);
			cs.Write(input, 0, input.Length);
			cs.Close();
			return ms.ToArray();
		}

	}
}
