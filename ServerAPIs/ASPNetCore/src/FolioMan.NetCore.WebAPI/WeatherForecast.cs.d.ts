declare module server {
	interface weatherForecast {
		date: Date;
		temperatureC: number;
		temperatureF: number;
		summary: string;
	}
}
