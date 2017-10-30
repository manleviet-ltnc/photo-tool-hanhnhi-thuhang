using System;
using System.IO;
using System.Text;

namespace Manning.MyPhotoAlbum
{
    class CryptoReader : StreamReader
    {
        private CryptoTextBase _base;
        private CryptoTextBase CryptoBase
        {
            get { return _base; }
        }

        public CryptoReader(string path, string password) : base(path)
        {
            if (path == null || path.Length == 0)
                throw new ArgumentNullException("path");
            if (password == null || password.Length == 0)
<<<<<<< HEAD
                throw new ArgumentNullException("password");
=======
                throw new ArgumentNullException("passwprd");
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42

            _base = new CryptoTextBase(password);
        }

        public override string ReadLine()
        {
            string encrypted = base.ReadLine();
            if (encrypted == null || encrypted.Length == 0)
                return encrypted;
            else
                return CryptoBase.ProcessText(encrypted, false);
<<<<<<< HEAD
=======
            return base.ReadLine();
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        }

        public string ReadUnencryptedLine()
        {
            return base.ReadLine();
        }
    }
}
