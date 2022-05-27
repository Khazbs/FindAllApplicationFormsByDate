using System.Collections.Generic;
using System;

class ApplicationService : IApplicationService {
	static ApplicationService _instance;
	ChronologicalRepo<IApplicationForm> _applications;
	
	ApplicationService() {
		_instance = this;
		_applications = new ChronologicalRepo<IApplicationForm>();
	}
	
	public IApplicationForm CreateApplication(
		IApplicant applicant,
		string body,
		DateTime dateTime
	) {
		IApplicationForm application = new ApplicationForm(
			applicant,
			body,
			dateTime
		);
		_applications.Add(application);
		return application;
	}

	public IEnumerable<IApplicationForm> FindApplicationsByDate(DateTime date) {
		return _applications.FindAllByDate(date);
	}
	
	public IEnumerable<IApplicationForm> GetApplications() {
		return _applications.All;
	}

	public static IApplicationService Instance =>
		_instance == null ? new ApplicationService() : _instance;
}
