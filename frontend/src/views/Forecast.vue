<template>
	<div>
		<p v-if="loading">
			<em>Loading...</em>
		</p>
		<div v-if="!loading">
			<h1>Weather forecast</h1>
			<p>This component demonstrates fetching data from the server.</p>
			<table>
				<thead>
					<tr>
						<th>Date</th>
						<th>Temp. (C)</th>
						<th>Temp. (F)</th>
						<th>Summary</th>
					</tr>
				</thead>
				<tbody>
					<tr v-for="forecast in forecasts" :key="forecast.date">
						<td>{{ forecast.date }}</td>
						<td>{{ forecast.temperatureC }}</td>
						<td>{{ forecast.temperatureF }}</td>
						<td>{{ forecast.summary }}</td>
					</tr>
				</tbody>
			</table>
		</div>
	</div>
</template>

<script>
export default {
	name: "Forecast",
	data() {
		return {
			forecasts: [],
			loading: true
		};
	},
	methods: {
		async populateWeatherData() {
			const response = await fetch("/api/weatherforecast");
			const data = await response.json();
			this.forecasts = data;
			this.loading = false;
		}
	},
	mounted() {
		this.populateWeatherData();
	}
};
</script>

<style scoped>
table {
	display: initial !important;
}
</style>
