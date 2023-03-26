declare module server {
	interface workHistoryModel {
		workHistoryGuidKeyId: any;
		jobTitle: string;
		employer: server.employerModel;
		workToFromRange: {
			fromDateTime: Date;
			toDateTime: Date;
			isCurrent: boolean;
		};
		workHighlights: server.workHighlightModel[];
	}
}
