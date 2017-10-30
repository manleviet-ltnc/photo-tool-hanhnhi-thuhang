using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manning.MyPhotoAlbum
{
    public class PhotoAlbum : Collection<Photograph>, IDisposable
    {
<<<<<<< HEAD
        public enum DescriptorOption { FileName, Caption, DateTaken }
=======
        public enum DescriptorOption { FileName, Caption, DakeTaken }
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
<<<<<<< HEAD
                HasChanged = true;
=======
                HasChaged = true;
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            }
        }

        private DescriptorOption _descriptor;
        public DescriptorOption PhotoDescriptor
        {
            get { return _descriptor; }
            set
            {
                _descriptor = value;
<<<<<<< HEAD
                HasChanged = true;
            }
        }
         public string GetDescriptorFormat()
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.Caption: return "c";
                case DescriptorOption.DateTaken: return "d";
                case DescriptorOption.FileName:
                default:
                    return "f";
            }
        }
=======
                HasChaged = true;
            }
        }
        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set
            {
                _pwd = value;
            }
        }


>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        private bool _hasChanged = false;
        public bool HasChanged
        {
            get
            {
                if (_hasChanged) return true;

                foreach (Photograph p in this)
                    if (p.HasChanged) return true;

                return false;
            }
            set
            {
                _hasChanged = value;
                if (value == false)
                    foreach (Photograph p in this)
                        p.HasChanged = false;
            }
        }

        public PhotoAlbum()
        {
            ClearSettings();
        }

        public Photograph Add(string filename)
        {
            Photograph p = new Photograph(filename);
            base.Add(p);
            return p;
        }

        private void ClearSettings()
        {
            _title = null;
            _descriptor = DescriptorOption.Caption;
        }

        protected override void ClearItems()
        {
            if (Count > 0)
            {
                Dispose();
                base.ClearItems();
<<<<<<< HEAD
                HasChanged = true;
=======
                HasChaged = true;
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
            }
        }

        protected override void InsertItem(int index, Photograph item)
        {
            base.InsertItem(index, item);
            HasChanged = true;
        }

        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChanged = true;
        }

        protected override void SetItem(int index, Photograph item)
        {
            base.SetItem(index, item);
            HasChanged = true;
        }

        public void Dispose()
        {
            ClearSettings();
            foreach (Photograph p in this)
                p.Dispose();
        }

<<<<<<< HEAD
        public string GetDescription(Photograph photo)
=======
        public string GetDescriptor(Photograph photo)
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.Caption:
                    return photo.Caption;
<<<<<<< HEAD
                case DescriptorOption.DateTaken:
                    return photo.DateTaken.ToShortDateString();
=======
                case DescriptorOption.DakeTaken:
                    return photo.DateTaken.ToLongDateString();
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
                case DescriptorOption.FileName:
                    return photo.FileName;
            }

            throw new ArgumentException("Unrecognized photo descriptor option.");
        }

        public string GetDescription(int index)
        {
<<<<<<< HEAD
            return GetDescription(this[index]);
=======
            return GetDescriptor(this[index]);
>>>>>>> 091d814457582f1de677ee03ae5b1f6e7b43ba42
        }
    }
}

