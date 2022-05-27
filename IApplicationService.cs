using System.Collections.Generic;
using System;

interface IApplicationService {
	IApplicationForm CreateApplication(
		IApplicant applicant,
		string body,
		DateTime dateTime
	);
	IEnumerable<IApplicationForm> FindApplicationsByDate(DateTime date);
	IEnumerable<IApplicationForm> GetApplications();
}
