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
        public enum DescriptorOption { FileName, Caption, DakeTaken }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                HasChaged = true;
            }
        }

        private DescriptorOption _descriptor;
        public DescriptorOption PhotoDescriptor
        {
            get { return _descriptor; }
            set
            {
                _descriptor = value;
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


        private bool _hasChanged = false;
        public bool HasChaged
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
                HasChaged = true;
            }
        }

        protected override void InsertItem(int index, Photograph item)
        {
            base.InsertItem(index, item);
            HasChaged = true;
        }

        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChaged = true;
        }

        protected override void SetItem(int index, Photograph item)
        {
            base.SetItem(index, item);
            HasChaged = true;
        }

        public void Dispose()
        {
            ClearSettings();
            foreach (Photograph p in this)
                p.Dispose();
        }

        public string GetDescriptor(Photograph photo)
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.Caption:
                    return photo.Caption;
                case DescriptorOption.DakeTaken:
                    return photo.DateTaken.ToLongDateString();
                case DescriptorOption.FileName:
                    return photo.FileName;
            }

            throw new ArgumentException("Unrecognized photo descriptor option.");
        }

        public string GetDescription(int index)
        {
            return GetDescriptor(this[index]);
        }
    }
}

