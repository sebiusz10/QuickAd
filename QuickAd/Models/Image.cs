using System;
namespace QuickAd.Models 
{
	public class Image 
    {
        private String ImagePath;
        private int Id;
        private String Hash;
        private String Extension;
        private bool IsPrivate;
        private int IdAdvert;

        #region ORM Properties

        public virtual int Vid {get { return this.Id; } set { this.Id = value; }}
        public virtual string Vpath {get { return this.ImagePath; } set { this.ImagePath = value; }}
        public virtual string Vextension {get { return this.Extension; } set { this.Extension = value; }}
        public virtual bool VisPrivate {get { return this.IsPrivate; } set { this.IsPrivate = value; }}
        public virtual int VidAdvertise {get { return this.IdAdvert; } set { this.IdAdvert = value; }}

        #endregion

        #region Properties

        public string GetImagePath() {return this.ImagePath;}
		public void SetImagePath(string imagePath) {this.ImagePath = imagePath;}

		public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

	    public String GetExtension() {return this.Extension;}
	    public void SetExtension(String extension) {this.Extension = extension;}

        #endregion
    }

}
