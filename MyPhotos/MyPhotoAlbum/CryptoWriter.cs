using System;
using System.IO;
using System.Text;

namespace Manning.MyPhotoAlbum
{
    class CryptoWriter : StreamWriter
    {
        private CryptoTextBase _base;
<<<<<<< HEAD
        private CryptoTextBase CryptoBase
=======
        private CryptoTextBase CrytoBase
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        {
            get { return _base; }
        }

        public CryptoWriter(string path, string password) : base(path)
        {
            if (path == null || path.Length == 0)
                throw new ArgumentNullException("path");
            if (password == null || password.Length == 0)
                throw new ArgumentNullException("password");

            _base = new CryptoTextBase(password);
        }

        public override void WriteLine(string value)
        {
<<<<<<< HEAD
            string encrypted = CryptoBase.ProcessText(value, true);
            base.WriteLine(encrypted);
        }

=======
            string encrypted = CrytoBase.ProcessText(value, true);
            base.WriteLine(encrypted);
        }
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        public void WriteUnencryptedLine(string value)
        {
            base.WriteLine(value);
        }
    }
}
