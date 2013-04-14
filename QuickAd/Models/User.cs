using System;
namespace QuickAd.Models 
{
	public class User 
    {
        private String FirstName;
        private String LastName;
        private String Email;
        private DateTime DateOfBirth;
        private String City;
        private String Street;
        private int BuildingNumber;
        private int HomeNumber;
        private Sex Sex;
        private String Password;
        private String PhoneNumber;
        private String Hash;
        private int Privillage;
        private int Id;
        private int IdSex;

        #region ORM Properties

        public virtual string VfirstName {get { return this.FirstName; } set { this.FirstName = value; }}
        public virtual string VlastName {get { return this.LastName; } set { this.LastName = value; }}
        public virtual string Vemail {get { return this.Email; } set { this.Email = value; }}
        public virtual DateTime VdateOfBirth {get { return this.DateOfBirth; } set { this.DateOfBirth = value; }}
        public virtual string Vcity {get { return this.City; } set { this.City = value; }}
        public virtual string Vstreet {get { return this.Street; } set { this.Street = value; }}
        public virtual int VbuildingNumber {get { return this.BuildingNumber; } set { this.BuildingNumber = value; }}
        public virtual int VhomeNumber {get { return this.HomeNumber; } set { this.HomeNumber = value; }}
        public virtual int VidSex {get { return this.IdSex; } set { this.IdSex = value; }}
        public virtual string Vpassword {get { return this.Password; } set { this.Password = value; }}
        public virtual string VphoneNumber {get { return this.PhoneNumber; } set { this.PhoneNumber = value; }}
        public virtual int Vprivillage { get { return this.Privillage; } set { this.Privillage = value; } }

        #endregion

        #region Properties

        public String GetFirstName() {return this.FirstName;}
		public void SetFirstName(String firstName) {this.FirstName = firstName;}

		public String GetLastName() {return this.LastName;}
		public void SetLastName(String lastName) {this.LastName = lastName;}

		public String GetEmail() {return this.Email;}
        public void SetEmail(String email) {this.Email = email;}

		public DateTime GetDateOfBirth() {return this.DateOfBirth;}
		public void SetDateOfBirth(DateTime dateOfBirth) {this.DateOfBirth = dateOfBirth;}

		public String GetCity() {return this.City;}
        public void SetCity(String city) {this.City = city;}

		public String GetStreet() {return this.Street;}
		public void SetStreet(String street) {this.Street = street;}

		public int GetBuildingNumber() {return this.BuildingNumber;}
		public void SetBuildingNumber(int buildingNumber) {this.BuildingNumber = buildingNumber;}

		public void GetAttribute() {throw new System.Exception("Not implemented");}
		public void SetAttribute(int attribute) {throw new System.Exception("Not implemented");}

		public int GetHomeNumber() {return this.HomeNumber;}
		public void SetHomeNumber(int homeNumber) {this.HomeNumber = homeNumber;}

		public Sex GetSex() {return this.Sex;}
		public void SetSex(Sex sex) {this.Sex = sex;}

		public String GetPassword() {return this.Password;}
		public void SetPassword(String password) {this.Password = password;}

		public String GetPhoneNumber() {return this.PhoneNumber;}
		public void SetPhoneNumber(String phoneNumber){this.PhoneNumber = phoneNumber;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

		public int GetPrivillage() {return this.Privillage;}
		public void SetPrivillage(int privillage) {this.Privillage = privillage;}

        public int GetId() { return this.Id; }
        public void SetId(int id) { this.Id = id; }

		public bool IsAdmin() {throw new System.Exception("Not implemented");}

		public void IsOwner(Advertise adv) {throw new System.Exception("Not implemented");}

        #endregion

        public Email CreateEmailTo(User user) 
        {
			throw new System.Exception("Not implemented");
		}

		private Email[] emails;
		private Advertise[] advertises;

	}

}
