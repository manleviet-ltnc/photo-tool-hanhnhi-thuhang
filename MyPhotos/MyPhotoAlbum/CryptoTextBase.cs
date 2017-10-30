using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
<<<<<<< HEAD

=======
using System.Text;
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42

namespace Manning.MyPhotoAlbum
{
    class CryptoTextBase
    {
        public readonly byte[] SaltBytes = { 0x39, 0x38, 0x14, 0x05, 0x68 };

        private byte[] _pwd;
        protected Byte[] Password { get { return _pwd; } }

        private MemoryStream _ms;
        protected MemoryStream MStream
        {
            get { return _ms; }
            set { _ms = value; }
        }

        private CryptoStream _cs;
        protected CryptoStream CStream
        {
            get { return _cs; }
            set { _cs = value; }
        }
<<<<<<< HEAD
        
=======

>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        public CryptoTextBase(string password)
        {
            if (password == null || password.Length == 0)
                throw new ArgumentNullException("password");
            _pwd = Encoding.UTF8.GetBytes(password);
<<<<<<< HEAD
        }
=======
        } 
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42

        /// <summary>
        /// Encrypt or decrypt a given string
        /// </summary>
        public string ProcessText(string text, bool encrypt)
        {
            // Encode text as byte array
            byte[] bytes = encrypt ? Encoding.UTF8.GetBytes(text) : Convert.FromBase64String(text);

            MStream = new MemoryStream();

<<<<<<< HEAD
            // Create default symmetric algorithm for cryption
=======
            // Create default symmetric algorithm.Create();
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            SymmetricAlgorithm alg = SymmetricAlgorithm.Create();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, SaltBytes);
            alg.Key = pdb.GetBytes(alg.KeySize / 8);
            alg.IV = pdb.GetBytes(alg.BlockSize / 8);
            ICryptoTransform transform = encrypt ? alg.CreateEncryptor() : alg.CreateDecryptor();

<<<<<<< HEAD
            // Create cryptographic stream
=======
            // Create cryptographic strean
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            CStream = new CryptoStream(MStream, transform, CryptoStreamMode.Write);

            // Encrypt data and flush result to buffer
            CStream.Write(bytes, 0, bytes.Length);
            CStream.FlushFinalBlock();

<<<<<<< HEAD
            // Retrieve the resulting bytes
            byte[] result = MStream.ToArray();

            // Convert result to a string
            return encrypt ? Convert.ToBase64String(result) : Encoding.UTF8.GetString(result);
        }
    }
=======
            // Retrieve the result to a string
            byte[] result = MStream.ToArray();

            // Covert result to a string
            return encrypt ? Convert.ToBase64String(result) : Encoding.UTF8.GetString(result);

        }
    } 

>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
}
