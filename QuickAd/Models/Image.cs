using System;
namespace Schemat obiektów logicznych {
	public class Image {
		private String imagePath;
		private String hash;
		private int id;
		private String extension;
		private bool isPrivate;

		public String GetImagePath() {
			return this.imagePath;
		}
		public void SetImagePath(out String imagePath) {
			this.imagePath = imagePath;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(out String hash) {
			this.hash = hash;
		}
		public int GetId() {
			return this.id;
		}
		public void SetId(out int id) {
			this.id = id;
		}
		public String GetExtension() {
			return this.extension;
		}
		public void SetExtension(out String extension) {
			this.extension = extension;
		}
		public bool GetIsPrivate() {
			return this.isPrivate;
		}
		public void SetIsPrivate(out bool isPrivate) {
			this.isPrivate = isPrivate;
		}


	}

}
