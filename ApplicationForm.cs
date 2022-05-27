using System;

class ApplicationForm : IApplicationForm {
	public ApplicationForm(
		IApplicant applicant,
		string body,
		DateTime dateTime
	) {
		Applicant = applicant;
		Body = body;
		DateTime = dateTime;
	}
	
	public IApplicant Applicant { get; }
	public string Body { get; }
	public DateTime DateTime { get; }
	
	new public string ToString() {
		return String.Format(
			"{0} @ {1}:\n\"{2}\"\n",
			Applicant.ToString(), DateTime, Body
		);
	}
}
