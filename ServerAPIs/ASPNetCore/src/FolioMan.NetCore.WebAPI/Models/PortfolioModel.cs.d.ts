declare module server {
	interface portfolioModel {
		portfolioGuidKeyId: any;
		candidate: server.candidateModel;
		portfolioName: string;
		portfolioDescription: string;
		workHistory: server.workHistoryModel[];
	}
}
