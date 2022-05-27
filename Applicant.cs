using System;

class Applicant : IApplicant {
	public Applicant (
		string firstName,
		string middleName,
		string lastName
	) {
		FirstName = firstName;
		MiddleName = middleName;
		LastName = lastName;
	}
	
	public string FirstName { get; }
	public string LastName { get; }
	public string MiddleName { get; }

	new public string ToString() {
		return String.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
	}
}
